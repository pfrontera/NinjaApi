using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NinjaApi.Controllers;
using NinjaApi.Core.Models;
using NinjaApi.Core.Services;

namespace NinjaApi.Tests
{
    public class NinjaControllerShould
    {
        private ClansController _controller;
        private Mock<IClanService> _clanServiceMock;

        [Fact]
        public async void ShouldReturnOkObjectResultWithClans()
        {
            var expectedClans = new List<Clan>()
            {
                new Clan() {Name = "Test clan 1"},
                new Clan() {Name = "Test clan 2"},
                new Clan() {Name = "Test clan 3"},
            };
            
            _clanServiceMock = new Mock<IClanService>();
            _controller = new ClansController(_clanServiceMock.Object);
            
            _clanServiceMock
                .Setup(x => x.ReadAllAsync())
                .ReturnsAsync(expectedClans);

            var result = await _controller.ReadAllAsync();

            var okResult = Assert.IsType<OkObjectResult>(result);
            
            Assert.Same(expectedClans, okResult.Value);
        }
    }
}