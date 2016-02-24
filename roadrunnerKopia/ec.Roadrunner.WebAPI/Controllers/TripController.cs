using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ec.Roadrunner.WebAPI.ControllerServices;
using ec.Roadrunner.WebAPI.Models;

namespace ec.Roadrunner.WebAPI.Controllers
{
    public class TripController : ApiController
    {
        
        readonly TripControllerService _trips = new TripControllerService();

       // [Route("api/trips")]
       // public HttpResponseMessage GetAll()
       // {
       //     var trips = _trips.GetAll();
       //     HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, trips);
       //     return response;
       // }
       // [Route("api/trips/approved")]
       //[HttpGet]
       // public HttpResponseMessage GetNotApproved()
       // {
       //     var trips = _trips.GetNotApproved();
       //     HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, trips);
       //     return response;
       // }
        [HttpGet]
        public UserTrip GetUserTrip(int userid) 
        {
            var trips = _trips.GetUserTrip(userid);
            return trips;
        }
        [Route("api/trips/create")]
        [HttpPost]
        public IHttpActionResult CreateUserTrip (int userId, Trip trip)
        {
            var trips = _trips.NewUserTrip(userId, trip);
            trips.Approved = false;
           
            return CreatedAtRoute("DefaultApi", new { id = trip.IdNr }, trip);
        }

        [HttpPut]
        public IHttpActionResult UpdateUserTrip(int tripId)
        {
            var trips = _trips.ModifyUserTrip(tripId);
            trips.Approved = false;

            return StatusCode(HttpStatusCode.OK);
        }
        //[Route("api/admin/create")]
        //[HttpPost]
        //public IHttpActionResult createTripAdmin(Trip trip)
        //{
        //    var trips = _trips.NewTripAdmin(trip);
        //    trips.NewTrip.Approved = false;

        //    return CreatedAtRoute("DefaultApi", new { id = trip.IdNr }, trip);
        //}
    }
}
