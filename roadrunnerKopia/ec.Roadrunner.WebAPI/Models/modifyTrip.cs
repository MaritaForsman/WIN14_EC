using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ec.Roadrunner.WebAPI.Models
{
    public class modifyTrip
    {
        
    public Trip newTrip { get; set; }
    public IList<Purpose> purpose { get; set; }
    public IList<Purpose> route { get; set; }
    public IList<UserProject> project { get; set; }
    }

    
}
