using System;
using NinjaApi.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace NinjaApi.Controllers
{
    [Route("v1/[controller]")]
    public class SuperCoolController : Controller
    {
        private readonly IChildService _childService;

        public SuperCoolController(IChildService childService)
        {
            _childService = childService ?? throw new ArgumentNullException(nameof(childService));
        }

        [HttpGet]
        public void MySuperCoolMethod()
        {
            _childService.DoSomething();
        }
    }
}
