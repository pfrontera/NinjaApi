using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NinjaApi.Core.Models;
using NinjaApi.Core.Services;

namespace NinjaApi.Controllers
{
    [Route("v1/[controller]")]
    public class ClansController : Controller
    {

        private readonly IClanService _clanService;

        public ClansController(IClanService clanService)
        {
            _clanService = clanService ?? throw new ArgumentNullException(nameof(clanService));
        }
        
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Clan>), 200)]
        public async Task<IActionResult> ReadAllAsync()
        {
            try
            {
                var allClans = await _clanService.ReadAllAsync();
                return Ok(allClans);
            }
            catch
            {
                return NotFound();
            }  
        }
    }
}