
using ec.Roadrunner.WebAPI.ControllerServices;
using ec.Roadrunner.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ec.Roadrunner.WebAPI.Controllers
{

    public class UserSettingsController : ApiController
    {
        readonly UserSettingsControllerService _controllerService = new UserSettingsControllerService();

        /// <summary>
        /// Get settings for specific user
        /// </summary>
        /// <param name = "userid" ></ param >
        /// < returns > list of usersettings</returns>
        //[Route("api/usersettings")]
        //public UserSetting Get(int userid)
        //{
        //    var userSetting = _controllerService.(userid);
        //    return userSetting;
        //}
        /// <summary>
        ///    get all visible settings from a specific user
        /// </summary>
        /// <param name = "userid" > id of the user</param>
        /// <returns>list of visible usersettings</returns>
        //[Route("Visible")]
        //[HttpGet]
        //public UserSetting GetVisible(int userid)
        //{
        //    var userSetting = _controllerService.(userid);
        //    return userSetting;
        //}

        [HttpGet]
        [Route("api/usersettings/route")]
        //public IQueryable<Purpose> GetRoute(int userid)
        //{
        //    var routes = _controllerService.GetRoute(userid);
        //    return routes;
        //}

        public Purpose PostTrip(Purpose route)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }
            var returnroute = _controllerService.addRoute(route);

            return returnroute;
        }
    }
}
