using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresidentsService.Models
{
    public class President
    {
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Birthplace { get; set; }
        public string Deathday { get; set; }
        public string Deathplace { get; set; }
    }
}
