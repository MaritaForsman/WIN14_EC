using ec.Roadrunner.WebAPI.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace ec.Roadrunner.WebAPI.Services
{
   public class TripAdminControllerService
    {
        readonly ecRoadrunnerContext _db = new ecRoadrunnerContext();

        public List<Trip> GetAll()
        {
            var trips = _db.Trips;
            return trips.ToList();
            
        }


        public List<Trip> GetNotApproved()
        {

            var _trips = _db.Trips.Where(t => t.Approved != true);

            return _trips.ToList();
        }

        
        public Trip NewTripAdmin(Trip trip)
        {
        
            trip.Approved = false;

            _db.Trips.Add(trip);
            _db.SaveChanges();

            return trip;
        }
        public Trip UpdateTripAdmin(int id,Trip trip)
        {

            _db.Entry(trip).State = EntityState.Modified;
            //try 
            //{
            //    _db.SaveChanges();
            //}
           
            // catch (DbUpdateConcurrencyException ex)
            //{
            //    if (!TripExists(id))
            //    {
            //        return ex.Message("not found");
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //_db.Trips.Add(trip);
            

            return trip;
        }

        //private bool TripExists(int id)
        //{
        //    return _db.Trips.Count(e => e.IdNr == id) > 0;
        //}
    }
}
