using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestAPI1.Models;

namespace TestAPI1.Models
{
    public class LexiconContext: DbContext
    {
        public LexiconContext(DbContextOptions<LexiconContext> options) : base(options)
        {
            

        }
        public DbSet<Lexicon> Lexicons { get; set; }
        public DbSet<TestAPI1.Models.Clans> Clans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClanDisciplines>()
                .HasKey(bc => new {bc.ClanId, bc.DisciplineId});
        }
    }
}
