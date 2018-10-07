using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace TestAPI1.Models
{
    public class Clans
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Bane { get; set; }
        public List<Archetypes> Archetypes { get; set; }
        public ICollection<ClanDisciplines> Disciplines { get; set; }
        public List<ClanFlavor> Flavor { get; set; }
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
        
        public int ClanId { get; set; }
        public Clans Clan { get; set; }
    }

    public class ThinBlood : Clans
    {
       public List<Details> Details { get; set; }
    }

    public class Details
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }

    public class ClanDisciplines
    {
        public int ClanId { get; set; }
        public Clans Clan { get; set; }
        public int DisciplineId { get; set; }
        public Disciplines Discipline { get; set; }
    }
}
