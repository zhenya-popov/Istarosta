using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.ContentForModerator
{
    public partial class EditPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserInfo user = UserInfo.GetById(Convert.ToInt32(Request.Params["postId"]));
                if (user == null)
                {
                    Response.Redirect("/news");
                }
                TextBox1.Text = user.Name;
                TextBox2.Text = user.Surname;
                TextBox3.Text = user.Patronymic;
                TextBox4.Text = user.Position;
                TextBox5.Text = user.Faculty;
                TextBox6.Text = user.PhoneNumber;
                TextBox7.Text = user.Email;
                TextBox8.Text = user.Skype;
                TextBox9.Text = user.Vkontakte;
                TextBox10.Text = user.Course.ToString();
            }           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserInfo user = UserInfo.GetById(Convert.ToInt32(Request.Params["postId"]));
            user.Name = TextBox1.Text;
            user.Surname = TextBox2.Text;
            user.Patronymic = TextBox3.Text;
            user.Position = TextBox4.Text;
            user.Faculty = TextBox5.Text; 
            user.PhoneNumber = TextBox6.Text;
            user.Email = TextBox7.Text;
            user.Skype = TextBox8.Text;
            user.Vkontakte = TextBox9.Text;
            user.Course = Convert.ToInt32(TextBox10.Text);
            UserInfo.UpdateInfo(user);
            Response.Redirect("/people");
        }
    }
}