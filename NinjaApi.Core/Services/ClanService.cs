using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NinjaApi.Core.Models;

namespace NinjaApi.Core.Services
{
    public class ClanService : IClanService
    {
        public Task<IEnumerable<Clan>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Clan> ReadOneAsync(string clanName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsClanExistsAsync(string clanName)
        {
            throw new NotImplementedException();
        }

        public Task<Clan> CreateAsync(Clan clan)
        {
            throw new NotSupportedException ();
        }

        public Task<Clan> UpdateAsync(Clan clan)
        {
            throw new NotSupportedException ();
        }

        public Task<Clan> DeleteAsync(string clanName)
        {
            throw new NotSupportedException ();
        }
    }
}