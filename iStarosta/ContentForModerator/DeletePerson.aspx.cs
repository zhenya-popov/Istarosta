using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iStarosta.ContentForModerator
{
    using global::iStarosta.Models;

    public partial class DeletePerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfo user = UserInfo.GetById(Convert.ToInt32(Request.Params["postId"]));
            if (user == null)
            {
                Response.Redirect("/people");
            }

            UserInfo.DeleteUser(user.Id);
            Response.Redirect("/people");
        }
    }
}