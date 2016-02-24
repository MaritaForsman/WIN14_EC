using ec.Roadrunner.WebAPI.ControllerServices;
using ec.Roadrunner.WebAPI.Models;
using ec.Roadrunner.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ec.Roadrunner.WebAPI.Controllers
{
    public class ProjectController : ApiController
    {
        readonly PurposeControllerService _controllerService = new PurposeControllerService();
        /// <summary>
        /// Get purpose per userid
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>

        [Route("api/usersettings/purpose")]
        //public HttpResponseMessage GetProject(int userid)
        //{
        //    var purpose = _controllerService.GetProject(userid).Where(p => p.Show == true);
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, purpose);
        //    return response;
        //}
        /// <summary>
        /// Create a new purpose for a specific user
        /// </summary>
        /// <param name="purpose"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        [Route("api/usersettings/purpose/create")]
        public HttpResponseMessage CreatePurpose([FromBody] Purpose purpose, int userid)
        {
            var purposes = _controllerService.AddPurpose(purpose, userid);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, purpose);

            return response;
        }
        /// <summary>
        /// Updates a purpose 
        /// </summary>
        /// <param name="purpose"></param>
        /// <returns></returns>
        [Route("api/usersettings/purpose/{id}")]
        //public HttpResponseMessage EditPurpose([FromBody] Purpose purpose, int id)
        //{
        //    var purposes = _controllerService.editPurpose(purpose, id);
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, purpose);
        //    return response;

        //}
        /// <summary>
        /// Delete of purpose based on purposeId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("api/usersettings/purpose/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var purposes = _controllerService.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
    }
}

