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
        public string Bane { get; set; }
        public ICollection<Archetypes> Archetypes { get; set; }
        public ICollection<Disciplines> Disciplines { get; set; }
        public ICollection<ClanFlavor> Flavor { get; set; }
    }

    public class ClanFlavor
    {
        public long Id { get; set; }
        public string Flavor { get; set; }
        public SourceBook Source { get; set; }
        public Clans Clan { get; set; }
    }

    public class Archetypes
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public Clans Clan { get; set; }
    }

    public class ThinBlood
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Archetypes> Archetypes { get; set; }
        public 
        public ICollection<ClanFlavor> Flavor { get; set; }

    }
}
