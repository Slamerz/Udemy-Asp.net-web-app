using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace TestAPI1.Models
{
    public class Disciplines
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<string> Nicknames { get; set; }
        public string Flavor { get; set; }
        public string Description { get; set; }

        public DisciplineCharacteristic Characteristic {get; set;}
        public ICollection<DisciplinePowers> Powers { get; set; }
    }
    public class DisciplineCharacteristic
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public Attribute Type { get; set; }
        public string Threat { get; set; }
        public string Resonance { get; set; }
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
        public Disciplines Discipline { get; set; }
    }
}

