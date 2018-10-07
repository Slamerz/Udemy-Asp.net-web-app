using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace TestAPI1.Models
{
    public class Disciplines
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<DisciplineNicknames> Nicknames { get; set; }
        public string Flavor { get; set; }
        public string Description { get; set; }

        public string CharacteristicsDescription { get; set; }
        public Attribute CharacteristicsType { get; set; }
        public string CharacteristicsThreat { get; set; }
        public string CharacteristicsResonance { get; set; }



        public ICollection<ClanDisciplines> Clans { get; set; }
        public List<DisciplinePowers> Powers { get; set; }
    }

    public class DisciplineNicknames
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int DisciplineId { get; set; }
        public Disciplines Discipline { get; set; }
    }
 
    public class DisciplinePowers
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DicePool { get; set; }
        public string Cost { get; set; }
        public string System { get; set; }
        public string Duration { get; set; }
        public int Level { get; set; }
        public int DisciplineId { get; set; }
        public Disciplines Discipline { get; set; }
    }
}

