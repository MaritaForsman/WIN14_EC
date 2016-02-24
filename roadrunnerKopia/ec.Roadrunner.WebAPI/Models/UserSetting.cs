using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ec.Roadrunner.WebAPI.Models
{
    /// <summary>
    /// </summary>
    public class UserSetting
    {
        /// <summary>
        /// </summary>
        public ICollection<Purpose> Routes { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<Purpose> Purposes { get; set; }

        /// <summary>
        /// </summary>
        public ICollection<UserProject> UserProjects { get; set; }
    }
}
