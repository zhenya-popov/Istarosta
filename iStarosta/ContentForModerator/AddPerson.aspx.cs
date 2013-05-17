using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.ContentForModerator
{
    public partial class AddPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Design/img/bsuPerson";
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            if (filename != "")
            {
                FileUpload1.PostedFile.SaveAs(Path.Combine(path, filename));
            }
            else
            {
                filename = "default.png";
            }
            UserInfo user = new UserInfo(){Name = TextBox1.Text, Surname = TextBox2.Text, Patronymic = TextBox3.Text, 
                Position = TextBox4.Text, Faculty = TextBox5.Text, PhoneNumber = TextBox6.Text, Email = TextBox7.Text,
            Skype = TextBox8.Text, Vkontakte = TextBox9.Text, Course = TextBox10.Text, ImageLink = filename};
            UserInfo.CreateUser(user);
            Response.Redirect("/people");
        }
    }
}