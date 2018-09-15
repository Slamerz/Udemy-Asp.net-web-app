using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestAPI1.Models
{
    public class LexiconContext: DbContext
    {
        public LexiconContext(DbContextOptions<LexiconContext> options) : base(options)
        {

        }
        public DbSet<Lexicon> Lexicons { get; set; }
    }
}
