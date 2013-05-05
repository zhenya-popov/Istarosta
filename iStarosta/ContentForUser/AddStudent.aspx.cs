using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.ContentForUser
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Group user = new Group(){Name = TextBox1.Text, Surname = TextBox2.Text, Patronymic = TextBox3.Text, Phone = TextBox4.Text,
            Email = TextBox5.Text};
            Group.AddToGroup(user);
            Response.Redirect("/group");
        }
    }
}