using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI1.Models
{
    public enum Adjective
    {
        Vulgar,
        Archaic
    }
    public class Lexicon
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Adjective? Adjective { get; set; }
        public string Definition { get; set; }
        public string See1 { get; set; }
        public string See2 { get; set; }
        public string See3 { get; set; }
    }
}
