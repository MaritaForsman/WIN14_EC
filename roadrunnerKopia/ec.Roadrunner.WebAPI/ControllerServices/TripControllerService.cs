using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ec.Roadrunner.WebAPI.Models;
using System.Data.Entity;

namespace ec.Roadrunner.WebAPI.ControllerServices
{
    class TripControllerService
    {
        readonly ecRoadrunnerContext _db = new ecRoadrunnerContext();

    //    public List<Trip> GetAll()
    //    {
    //        var trips = _db.Trips;
    //        return trips.ToList();
    //    }
    

    //public List<Trip> GetNotApproved()
    //    {
            
    //       var _trips = _db.Trips.Where(t => t.Approved != true);
            
    //        return _trips.ToList();
    //    }

        public UserTrip GetUserTrip(int userId)
        {
            UserTrip usertrip = new UserTrip();
            {
                var _usertrip = _db.Trips.Where(t => t.IdNr == userId);
            }
            return usertrip;
        }

        public Trip NewUserTrip (int userId, Trip trip)
        {
            _db.Trips.Add(trip);        
        
            _db.SaveChanges();
            return trip;
        }

        public Trip ModifyUserTrip(int tripId)
        {
            var trip = _db.Trips.Where(t => t.IdNr == tripId);
            _db.Entry(trip).State = EntityState.Modified;
           _db.SaveChanges();
            return null;
        }
        //public AdminCreateTrip NewTripAdmin (Trip trip)
        //{
        //    AdminCreateTrip newtrip = new AdminCreateTrip();
            
        //    newtrip.NewTrip.Approved = false;
            
        //    _db.Trips.Add(trip);
        //    _db.SaveChanges();
        //    //newtrip.NewTrip.Object = _db.Projects.Where(p => p.ProjectId == trip.Project)
        //    return newtrip;
        //}
    }
}
