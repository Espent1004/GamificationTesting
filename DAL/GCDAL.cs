using Model.DBModels;
using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GCDAL
    {

        public List<GCPGS> GetAll()
        {
            using (var gcContext = new GCContext())
            {
                List<GCPGS> pgsList = gcContext.PersonGameStats.Select(pgs => new GCPGS()
                {

                    PersonGameStatsId = pgs.PersonGameStatsId,
                    Person = new GCPerson()
                    {
                        PersonID = pgs.Person.PersonID,
                        Name = pgs.Person.Name
                    },
                    XP = pgs.XP,
                    Coins = pgs.Coins,
                    Level = new GCLevel()
                    {
                        LevelId = pgs.Level.LevelId,
                        LevelNumber = pgs.Level.LevelNumber,
                        XPBreakPoint = pgs.Level.XPBreakPoint
                    }
                }).ToList();

                return pgsList;
            }
        }

        public void HandleEvent(GCEvent gcevent)
        {

            if(gcevent.XPReward != 0)
            {
                AddXp(gcevent);
            }
            
        }



        private void AddXp(GCEvent gcevent)
        {
            using (var gcContext = new GCContext())
            {
                PersonGameStats pgs = gcContext.PersonGameStats.FirstOrDefault(p => p.PersonId == gcevent.PersonId);
                int oldXP = pgs.XP;
                int oldLvl = pgs.Level.LevelNumber;


                pgs.XP += gcevent.XPReward;

                if (pgs.XP >= pgs.Level.XPBreakPoint)//LEVEL UP
                {
                    Level lvl = gcContext.Levels.FirstOrDefault(l => l.LevelNumber == oldLvl + 1);
                    pgs.Level = lvl;
                }
                try
                {
                    gcContext.SaveChanges();
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
            }
        }
    }
}
