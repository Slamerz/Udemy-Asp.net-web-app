using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.API.Common1.Services;
using DotNetCore.API.Common1.Services.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCore.API.Common1.API.Controllers
{
    [Route("api/[controller]")]
    public class LexiconController : Controller
    {
        private string DB = "mongodb://vampdb-sbaty.gcp.mongodb.net:27017";
        // GET: api/<controller>
        [HttpGet]
        public async Task<JsonResult> Get()
        {
            var mongodbService = new MongoDBService("VampireTheMasuerade5", "Lexicon", DB);
            var allLexicons = await mongodbService.GetAllLexiconsAsync();

            return Json(allLexicons);
        }
        // POST api/<controller>
        [HttpPost]
        public async Task Post([FromBody]Lexicon lexicon)
        {
            var mongoDbService = new MongoDBService("VampireTheMasuerade5", "Lexicon", DB);
            await mongoDbService.InsterLexicon(lexicon);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
