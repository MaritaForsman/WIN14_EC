using ec.Roadrunner.WebAPI.Models;
using ec.Roadrunner.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace ec.Roadrunner.WebAPI.Controllers
{
    [EnableCorsAttribute("*", "*", "*")]
    /// <summary>
    /// Controller for Route for specific user
    /// </summary>
    public class RouteController : ApiController
    {
        private RouteControllerService _controllerService = new RouteControllerService();

        /// <summary>
        /// Get routes per userid
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        [Route("api/usersettings/routes/{userid}")]
        [HttpGet]
        [ResponseType(typeof(Route))]
        
        public IHttpActionResult GetRoutes(int userid)
        {
            try
            {
                return Ok(_controllerService.GetRoutes(userid).ToList());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        /// <summary>
        /// Create a new routes for a specific user
        /// </summary>
        /// <param name="routes"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        [Route("api/usersettings/routes/create")]
        public HttpResponseMessage Createroutes([FromBody] Route routes, int userid)
        {
            var routess = _controllerService.AddRoutes(routes, userid);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, routes);

            return response;
        }
        /// <summary>
        /// Updates a routes 
        /// </summary>
        /// <param name="routes"></param>
        /// <returns></returns>
        [Route("api/usersettings/routes/{id}")]
        //public HttpResponseMessage Editroutes([FromBody] Route routes, int id)
        //{
        //    var routess = _controllerService.(routes, id);
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, routes);
        //    return response;

        //}
        /// <summary>
        /// Delete of routes based on routesId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("api/usersettings/routes/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var routess = _controllerService.Delete(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
    }
}
