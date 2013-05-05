using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.ContentForUser
{
    public partial class EditStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Group user = Group.GetById(Convert.ToInt32(Request.Params["postId"]));
                if (user == null)
                {
                    Response.Redirect("/news");
                }
                TextBox1.Text = user.Name;
                TextBox2.Text = user.Surname;
                TextBox3.Text = user.Patronymic;
                TextBox4.Text = user.Phone;
                TextBox5.Text = user.Email;
            }        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Group user = Group.GetById(Convert.ToInt32(Request.Params["postId"]));
            user.Name = TextBox1.Text;
            user.Surname = TextBox2.Text;
            user.Patronymic = TextBox3.Text;
            user.Phone = TextBox4.Text;
            user.Email = TextBox5.Text;
            Group.UpdateInfo(user);
            Response.Redirect("/group");
        }
    }
}