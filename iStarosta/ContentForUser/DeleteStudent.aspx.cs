using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.ContentForUser
{
    public partial class DeleteStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Group user = Group.GetById(Convert.ToInt32(Request.Params["postId"]));
            if (user == null)
            {
                Response.Redirect("/group");
            }

            Group.DeleteFromGroup(user.Id);
            Response.Redirect("/group");
        }
    }
}