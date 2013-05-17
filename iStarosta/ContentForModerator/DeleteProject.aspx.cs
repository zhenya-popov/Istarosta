using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.ContentForModerator
{
    public partial class DeleteProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Project project = Project.GetById(Convert.ToInt32(Request.Params["postId"]));
            if (project != null)
            {
                Project.DeleteProject(project.Id);
            }
            Response.Redirect("/projects");
        }
    }
}