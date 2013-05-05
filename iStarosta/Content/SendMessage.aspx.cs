using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iStarosta.Content
{
    using global::iStarosta.Models;

    public partial class SendMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var list = BsuUser.GetUsers().Select(user => user.Email).ToList();
            DropDownList1.DataSource = list;
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Messages.Send(new Messages { Message = TextBox1.Text, Sender = HttpContext.Current.User.Identity.Name, Addressee = DropDownList1.SelectedValue });
            Response.Redirect("/profile");
        }
    }
}