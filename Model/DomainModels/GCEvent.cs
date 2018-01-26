using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModels
{
    public class GCEvent
    {
        public int EventId { get; set; }
        public String EventName { get; set; }
        public int XPReward { get; set; }
        public int PersonId { get; set; }
    }
}
