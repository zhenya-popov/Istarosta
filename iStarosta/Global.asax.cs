using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace iStarosta
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("", "news", "~/Content/News.aspx");
            routes.MapPageRoute("", "news/add", "~/ContentForModerator/AddNews.aspx");
            routes.MapPageRoute("", "about", "~/Content/About.aspx");
            routes.MapPageRoute("", "clause", "~/Content/Clause.aspx");
            routes.MapPageRoute("", "login", "~/Content/Login.aspx");
            routes.MapPageRoute("", "people", "~/Content/People.aspx");
            routes.MapPageRoute("", "photo", "~/Content/Photo.aspx");
            routes.MapPageRoute("", "projects", "~/Content/Projects.aspx");
            routes.MapPageRoute("", "adduser", "~/ContentForAdmin/AddUser.aspx");
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}