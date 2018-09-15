using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI1.Models
{
    public class Lexicon
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public List<LexiconSeeOther> SeeOther { get; set; }
    }

    public class LexiconSeeOther
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
