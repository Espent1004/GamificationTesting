using BLL;
using Model.DBModels;
using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace GamificationPOC.Controllers
{
    public class GCController : ApiController
    {
        private GCBLL GCBLL;

        public GCController()
        {
            GCBLL = new GCBLL();

        }
        public HttpResponseMessage Get()
        {
            List<GCPGS> allPGS = GCBLL.GetAll();

            var Json = new JavaScriptSerializer();
            string JsonString = Json.Serialize(allPGS);

            return new HttpResponseMessage()
            {
                Content = new StringContent(JsonString, Encoding.UTF8, "application/json"),
                StatusCode = HttpStatusCode.OK
            };

        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody]GCEvent gcevent)
        {
            GCBLL.HandleEvent(gcevent);

            return new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK
            };
        }
    }
}
