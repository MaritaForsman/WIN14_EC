using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ec.Roadrunner.WebAPI.Controllers
{
    [Authorize]
    public class ValuesController : ApiController {

        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // GET api/values
        public IEnumerable<string> Get()
        {
            Log.DebugFormat("no paramteres");
            string[] strings = { "value1", "value2" };
            Log.DebugFormat("Returning {0}",strings);
            return strings;
        }

        // GET api/values/5
        public string Get(int id)
        {
            Log.DebugFormat("id={0}",id);
            
            Log.DebugFormat("Returning {0}", "value");
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
