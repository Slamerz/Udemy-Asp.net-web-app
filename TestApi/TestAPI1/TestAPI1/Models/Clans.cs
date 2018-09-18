using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI1.Models
{
    public class Clans
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Archetypes> Archetypes { get; set; }
        public ICollection<Disciplines> Disciplines { get; set; }
    }

    public class Archetypes
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public Clans Clan { get; set; }
    }

}
