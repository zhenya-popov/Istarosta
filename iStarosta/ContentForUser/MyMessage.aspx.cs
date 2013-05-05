using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iStarosta.ContentForUser
{
    using global::iStarosta.Models;

    public partial class MyMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = Messages.GetMessages();
            Repeater1.DataBind();
        }
    }
}