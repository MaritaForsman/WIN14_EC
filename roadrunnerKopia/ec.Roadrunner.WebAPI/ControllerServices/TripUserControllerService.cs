using ec.Roadrunner.WebAPI.Models;
using System.Data.Entity;
using System.Linq;

namespace ec.Roadrunner.WebAPI.Services
{
    class TripUserControllerService
    {
        private ecRoadrunnerContext _db = new ecRoadrunnerContext();

        public UserTrip GetUserTrip(int userId)
        {
            UserTrip userTrip = new UserTrip();
            userTrip.NewTrip = new Trip() { UserId = userId };
            userTrip.Purposes = _db.Purposes.Where(a => a.UserId == userId && a.Show == true).ToList();
            userTrip.Routes = _db.Routes.Where(a => a.UserId == userId && a.Show == true).ToList();
            userTrip.Projects = _db.UserProjects.Where(a => a.UserId == userId && a.Show == true).ToList();
            return userTrip;
        }

        public Trip NewUserTrip(int userId, Trip trip)
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
    }
}
