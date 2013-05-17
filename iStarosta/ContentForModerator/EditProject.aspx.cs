using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.ContentForModerator
{
    public partial class EditProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Project project = Project.GetById(Convert.ToInt32(Request.Params["postId"]));
                if (project == null)
                {
                    Response.Redirect("/projects");
                }
                TextBox1.Text = project.Name;
                TextArea1.InnerText = project.Description;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Project project = Project.GetById(Convert.ToInt32(Request.Params["postId"]));
            project.Name = TextBox1.Text;
            project.Description = TextArea1.InnerText;
            Project.UpdateProject(project);
            Response.Redirect("/projects");
        }
    }
}