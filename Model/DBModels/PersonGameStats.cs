using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DBModels
{
    public class PersonGameStats
    {
        public int PersonGameStatsId { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public int XP { get; set;}
        public int Coins { get; set; }
        public int LevelId { get; set; }
        public virtual Level Level { get; set; }
    }
}
