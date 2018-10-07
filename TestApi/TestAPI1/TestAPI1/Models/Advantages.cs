using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace TestAPI1.Models
{
    public class Advantages
    {
        public string Name { get; set; }
        public ICollection<Merits> Merits { get; set; }
        public ICollection<Flaws> Flaws { get; set; }
    }

    public class Backgrounds: Advantages
    {
       
    }   


    public class Merits
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Requirement { get; set; }
        public string Description { get; set; }
        public AdvantageType Type { get; set; }
    }

    public class Flaws : Merits
    {

    }

    public class AdvantageType
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Merits> Merits { get; set; }
        public ICollection<Flaws> Flaws { get; set; }
    }
}
