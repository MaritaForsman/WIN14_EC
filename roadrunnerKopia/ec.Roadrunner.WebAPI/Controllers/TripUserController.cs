using ec.Roadrunner.WebAPI.Models;
using ec.Roadrunner.WebAPI.Services;
using System.Net;
using System.Web.Http;

namespace ec.Roadrunner.WebAPI.Controllers
{
    /// <summary>
    /// Controller for User to their trips
    /// </summary>
    public class TripUserController : ApiController
    {
     private TripUserControllerService _trips = new TripUserControllerService();

     /// <summary>
     /// Get Trips based on userid
     /// </summary>
     /// <param name="userid"></param>
     /// <returns></returns>
        [HttpGet]
        public UserTrip GetUserTrip(int userid)
        {
            var trips = _trips.GetUserTrip(userid);
            return trips;
        }

        /// <summary>
        /// Create new trip by a specific user
        /// </summary>
        /// <param name="userId">Userid</param>
        /// <param name="trip">Trip</param>
        /// <returns></returns>
        [Route("api/trips/create")]
        [HttpPost]
        public IHttpActionResult CreateUserTrip(int userId, Trip trip)
        {
            var trips = _trips.NewUserTrip(userId, trip);
            trips.Approved = false;

            return CreatedAtRoute("DefaultApi", new { id = trip.IdNr }, trip);
        }

        /// <summary>
        /// Update own trips based on userid
        /// </summary>
        /// <param name="tripId"></param>
        /// <returns></returns>

        [HttpPut]
        public IHttpActionResult UpdateUserTrip(int tripId)
        {
            var trips = _trips.ModifyUserTrip(tripId);
            trips.Approved = false;

            return StatusCode(HttpStatusCode.OK);
        }
    }
}
