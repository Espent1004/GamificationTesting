using DAL;
using Model.DBModels;
using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GCBLL
    {

        private GCDAL GCDAL;
        public GCBLL()
        {
            GCDAL = new GCDAL();
        }
        public List<GCPGS> GetAll()
        {

            return GCDAL.GetAll();
        }

        public void HandleEvent(GCEvent gcevent)
        {

            GCDAL.HandleEvent(gcevent);
        }
    }
}
