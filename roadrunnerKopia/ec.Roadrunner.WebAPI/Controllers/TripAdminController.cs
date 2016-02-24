using ec.Roadrunner.WebAPI.Models;
using ec.Roadrunner.WebAPI.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace ec.Roadrunner.WebAPI.Controllers
{
   [EnableCorsAttribute("http://localhost:1541", "*", "*")]

    /// <summary>
    /// Controller to handle trips for Admin
    /// </summary>
    public class TripAdminController : ApiController
    {
    
       public TripAdminControllerService _trips = new TripAdminControllerService();
        
        /// <summary>
        /// Get all trips
        /// </summary>
        /// <returns>list of trips</returns>
       [Route("api/admin/searchtrips")]
       [HttpGet]
       [ResponseType(typeof(Trip))]

        public IHttpActionResult GetAll()
        {
            try 
            {
                return Ok(_trips.GetAll());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
            
        }

        /// <summary>
        /// Get all not approved trips
        /// </summary>
        /// <returns>List of not approved trips</returns>
        [Route("api/admin/approved")]
        [HttpGet]
        [ResponseType(typeof(Trip))]
        public IHttpActionResult GetNotApproved()
        {
            try
            {
                return Ok(_trips.GetNotApproved());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }




        /// <summary>
        /// Create a new trip
        /// </summary>
        /// <param name="trip"></param>
        /// <returns></returns>
        [Route("api/admin/create")]
        [HttpPost]
        public IHttpActionResult createTripAdmin([FromBody] Trip trip)
        {
            try 
            {
                return Ok(_trips.NewTripAdmin(trip));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }
        /// <summary>
        /// Update trip
        /// </summary>
        /// <param name="trip"></param>
        /// <returns></returns>
        [Route("api/admin/update/{id}")]
        [HttpPut]
        public IHttpActionResult updateAdminTrip(int id, [FromBody] Trip trip)
        {
            try
            {
                return Ok(_trips.UpdateTripAdmin(id, trip));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }
    }
}
