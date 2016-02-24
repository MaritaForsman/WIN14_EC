using ec.Roadrunner.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ec.Roadrunner.WebAPI.Services
{
    /// <summary>
    /// Service for Route controller
    /// </summary>
    public class RouteControllerService
    {
        private ecRoadrunnerContext _db = new ecRoadrunnerContext();

        /// <summary>
        /// Get purpose based on user
        /// </summary>
        /// <param name="userid">The specific users id</param>
        /// <returns>List of purposes</returns>
        public List<Route> GetRoutes(int userid)
        {
            return _db.Routes.Where(p => p.UserId == userid).ToList();

        }

        /// <summary>
        /// Add a new route for a specific user
        /// </summary>
        /// <param name="routes"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Route AddRoutes(Route routes, int userid)
        {
            List<Route> _routes = new List<Route>();

            if (routes == null)
            {
                throw new ArgumentNullException("Routes");
            }

            _routes.Add(routes);
            return routes;
        }

        /// <summary>
        /// Edit a specific purpose for a specific user
        /// </summary>
        /// <param name="routes">Retrives existing data</param>
        /// <param name="id">routeid</param>
        /// <returns></returns>
        public Route EditRoutes(Route routes, int id)
        {
            var dbRoutes = _db.Routes.FirstOrDefault(p => p.RouteId == id);
            dbRoutes.Description = routes.Description;
            dbRoutes.Show = routes.Show;
            dbRoutes.UserId = routes.UserId;
            _db.SaveChanges();
            return dbRoutes;
        }

        /// <summary>
        /// Remove a specific route
        /// </summary>
        /// <param name="id">routerid</param>
        /// <returns></returns>
        public Route Delete(int id)
        {
            var Routes = _db.Routes.FirstOrDefault(p => p.RouteId == id);
            _db.Routes.Remove(Routes);
            _db.SaveChanges();
            return null;
        }
    }
}
