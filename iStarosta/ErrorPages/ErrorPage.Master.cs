using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iStarosta.ErrorPages
{
    public partial class ErrorPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.User.Identity.Name != "")
            {
                HyperLink1.Visible = false;
                LinkButton1.Visible = true;
            }
            else
            {
                HyperLink1.Visible = true;
                LinkButton1.Visible = false;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            HyperLink1.Visible = true;
            LinkButton1.Visible = false;
            Response.Redirect("/news");
        }
    }
}