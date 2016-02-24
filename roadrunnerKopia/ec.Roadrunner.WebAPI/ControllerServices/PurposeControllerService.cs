using ec.Roadrunner.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ec.Roadrunner.WebAPI.Services
{
    /// <summary>
    /// Service for Purpose controller
    /// </summary>
    public class PurposeControllerService
    {
        private ecRoadrunnerContext _db = new ecRoadrunnerContext();


        /// <summary>
        /// Get purpose based on user
        /// </summary>
        /// <param name="userid">The specific usersid</param>
        /// <returns>List of purposes</returns>
        public List<Purpose> GetPurpose(int userid)
        {
            return _db.Purposes.Where(p => p.UserId == userid).Where(p => p.Show == true).ToList();

        }

        /// <summary>
        /// Add a new purpose for a specific user
        /// </summary>
        /// <param name="purpose"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public Purpose AddPurpose(Purpose purpose, int userid)
        {
            List<Purpose> _purpose = new List<Purpose>();

            if (purpose == null)
            {
                throw new ArgumentNullException("purpose");
            }

            _purpose.Add(purpose);
            return purpose;
        }

        /// <summary>
        /// Edit a specific purpose for a specific user
        /// </summary>
        /// <param name="purpose">Retrives existing data</param>
        /// <param name="id">purposeid</param>
        /// <returns></returns>
        public Purpose EditPurpose(Purpose purpose, int id)
        {
            var dbpurpose = _db.Purposes.FirstOrDefault(p => p.PurposeId == id);
            dbpurpose.Description = purpose.Description;
            dbpurpose.Show = purpose.Show;
            dbpurpose.UserId = purpose.UserId;
            _db.SaveChanges();
            return dbpurpose;
        }

        /// <summary>
        /// Remove a specific purpose
        /// </summary>
        /// <param name="id">purposeid</param>
        /// <returns></returns>
        public Purpose Delete(int id)
        {
            var purpose = _db.Purposes.FirstOrDefault(p => p.PurposeId == id);
            _db.Purposes.Remove(purpose);
            _db.SaveChanges();
            return null;
        }
    }
}

