using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using NinjaApi.Controllers;
using NinjaApi.Core.Models;
using NinjaApi.Core.Services;
using Xunit;

namespace NinjaApi.Tests
{
    public class ClanServiceShould
    {
        private IClanService _clanService;

        public ClanServiceShould()
        {
            _clanService = new ClanService();
        }
        
        [Fact]
        public async Task ShouldReturnAllClans()
        {            
            var expectedClans = new List<Clan>()
            {
                new Clan() {Name = "Test clan 1"},
                new Clan() {Name = "Test clan 2"},
                new Clan() {Name = "Test clan 3"},
            };

            var result = await _clanService.ReadAllAsync();

            Assert.Same(expectedClans, result);
        }

        [Fact]
        public async Task ShouldReturnTheExpectedClan()
        {
            var clanName = "The Foot Clan";
            var expectedClan = new Clan() {Name = clanName};

            var result = await _clanService.ReadOneAsync(clanName);

            result.Should().BeSameAs(expectedClan);
        }

        [Fact]
        public async Task ShouldReturnNullIfTheClanDoesNotExist()
        {
            var clanName = "The Clan of the Bat";

            var result = await _clanService.ReadOneAsync(clanName);

            result.Should().Be(null);
        }

        [Fact]
        public async Task ShouldReturnTrueIfTheClanExist()
        {
            var clanName = "Konoha Clan";

            var result = await _clanService.IsClanExistsAsync(clanName);

            result.Should().Be(true);
        }
        
        [Fact]
        public async Task ShouldReturnFalseIfTheClanExist()
        {
            var clanName = "Unexisting Clan";

            var result = await _clanService.IsClanExistsAsync(clanName);

            result.Should().Be(false);
        }

        [Fact]
        public async Task ShouldCreateAndReturnTheSpecifiedClan()
        {
            await Assert.ThrowsAsync<NotSupportedException>(() => _clanService.CreateAsync(null));
        }
        
        [Fact]
        public async Task ShouldUpdateAndReturnTheSpecifiedClan()
        {
            await Assert.ThrowsAsync<NotSupportedException>(() => _clanService.CreateAsync(null));
        }
        
        [Fact]
        public async Task ShouldDeleteAndReturnTheSpecifiedClan()
        {
            await Assert.ThrowsAsync<NotSupportedException>(() => _clanService.CreateAsync(null));
        }
        
    }
    
    
}