using ec.Roadrunner.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ec.Roadrunner.WebAPI.ControllerServices
{
    class UserSettingsControllerService
    {
        readonly ecRoadrunnerContext _db = new ecRoadrunnerContext();

        //public UserSetting Get(int userid)
        //{
        //    UserSetting userSetting = new UserSetting
        //    {
        //        Routes = _db.Routes.Where(r => r.UserId == userid),
        //        Purposes = _db.Purposes.Where(p => p.Anr == userid).ToList(),
        //        UserProjects = new List<UserProject>()
        //    };

        //    var queryable = _db.UserProjects.Where((up => up.UserId == userid)).Select(u => u.ProjectId);

        //    foreach (var variable in queryable)
        //    {
        //        var firstOrDefault = _db.Projects.FirstOrDefault(p => p.Id == variable);
        //        if (firstOrDefault == null) continue;
        //        userSetting.UserProjects.Add(new UserProject { ProjectId = variable, Projectname = firstOrDefault.name });
        //    }

        //    return userSetting;
        //}

        //public IQueryable<Route> GetRoute(int userid)
        //{
        //    Route usersetting = new Route();
        //    {
        //        var _routes = _db.Routes.Where(r => r.UserId == userid);
        //        return _routes.ToList();
        //    }
            
        //}
        //public UserSetting GetVisible(int userid)
        //{
        //    UserSetting userSetting = new UserSetting
        //    {
        //        Routes = _db.Routes.Where(t => t.UserId == userid ).ToList(),
        //        Purposes = _db.Purposes.Where(p => p.UserId == userid & p.Visible).ToList(),
        //        UserProjects = new List<UserProject>()
        //    };

        //    var queryable = _db.UserProjects.Where((up => up.UserId == userid)).Select(u => u.ProjectId);

        //    foreach (var variable in queryable)
        //    {
        //        var firstOrDefault = _db.Projects.FirstOrDefault(p => p.ProjectId == variable);
        //        if (firstOrDefault == null) continue;
        //        userSetting.UserProjects.Add(new UserProject { ProjectId = variable, Projectname = firstOrDefault.name });
        //    }

        //    return userSetting;

        //}

        public Purpose addRoute(Purpose route)
        {
            List<Purpose> _route = new List<Purpose>();
            if (route == null)
            {
                throw new ArgumentNullException("route");
            }
            _route.Add(route);
            return route;
        }
        public Purpose addPurpose(Purpose purpose)
        {
            List<Purpose> _purpose = new List<Purpose>();

            if (purpose == null)
            {
                throw new ArgumentNullException("purpose");
            }
            _purpose.Add(purpose);
            return purpose;
        }
        public UserProject addproject(UserProject project)
        {
            List<UserProject> _project = new List<UserProject>();

            if (project == null)
            {
                throw new ArgumentNullException("purpose");
            }
            _project.Add(project);
            return project;
        }


    }
}
