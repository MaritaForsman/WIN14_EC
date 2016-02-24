using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ec.Roadrunner.WebAPI.Models
{
    public class AdminCreateTrip
    {
        public IList<LoginAnr> UserId = new List<LoginAnr>();
        public Trip NewTrip { get; set; }
        
    }
}
