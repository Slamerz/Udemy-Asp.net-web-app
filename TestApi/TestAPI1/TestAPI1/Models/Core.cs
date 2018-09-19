using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace TestAPI1.Models
{
    public class SourceBook
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set;}
        public string BuyLink { get; set; }
    }
}
