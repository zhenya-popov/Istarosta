using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iStarosta.Content
{
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Models.BsuUser news = Models.BsuUser.GetByName(Page.User.Identity.Name);
                if (news == null)
                {
                    Response.Redirect("/people");
                }

                txtBirthday.Text = news.Birthday;
            }
        }
    }
}