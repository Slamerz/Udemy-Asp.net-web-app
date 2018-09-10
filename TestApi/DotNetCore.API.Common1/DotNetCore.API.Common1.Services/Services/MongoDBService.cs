using DotNetCore.API.Common1.Services.Contracts;
using DotNetCore.API.Common1.Services.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCore.API.Common1.Services
{
    public class MongoDBService : ILexiconService
    {
        private IMongoCollection<Lexicon> Lexiconcollection { get; }

        public MongoDBService(string databaseName, string collectionName, string databaseUrl)
        {
            var mongoClient = new MongoClient(databaseUrl);
            var mongoDatabase = mongoClient.GetDatabase(databaseName);
            Lexiconcollection = mongoDatabase.GetCollection<Lexicon>(collectionName);
        }

        public async Task InsterLexicon(Lexicon lex) => await Lexiconcollection.InsertOneAsync(lex);

        public async Task<List<Lexicon>> GetAllLexiconsAsync()
        {
            var lexicons = new List<Lexicon>();

            var allDocuments = await Lexiconcollection.FindAsync(new BsonDocument());
            await allDocuments.ForEachAsync(doc => lexicons.Add(doc));

            return lexicons;
        }





        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public Task<string> CreateAsync(Lexicon user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Lexicon user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task<Lexicon> GetAsync(ObjectId id)
        {
            throw new NotImplementedException();
        }
    }
}
