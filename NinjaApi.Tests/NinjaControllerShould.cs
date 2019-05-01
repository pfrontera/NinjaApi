using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NinjaApi.Controllers;
using NinjaApi.Core.Models;

namespace NinjaApi.Tests
{
    public class NinjaControllerShould
    {
        private ClansController _controller;

        [Fact]
        public async void ShouldReturnOkObjectResultWithClans()
        {
            var expectedClans = new List<Clan>()
            {
                new Clan() {Name = "Test clan 1"},
                new Clan() {Name = "Test clan 2"},
                new Clan() {Name = "Test clan 3"},
            };
            
            _controller = new ClansController();

            var result = await _controller.ReadAllAsync();

            var okResult = Assert.IsType<OkObjectResult>(result);
            
            Assert.Same(expectedClans, okResult.Value);
        }
    }
}