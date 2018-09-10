using DotNetCore.API.Common1.Services.Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCore.API.Common1.Services.Contracts
{
    public interface ILexiconService
    {
        Task<string> CreateAsync(Lexicon user);

        Task<bool> UpdateAsync(Lexicon user);

        Task<bool> DeleteAsync(ObjectId id);

        Task<Lexicon> GetAsync(ObjectId id);
    }
}
