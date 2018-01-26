using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModels
{
    public class GCPGS
    {
        public int PersonGameStatsId { get; set; }
        public GCPerson Person { get; set; }
        public int XP { get; set; }
        public int Coins { get; set; }
        public GCLevel Level { get; set; }
    }
}
