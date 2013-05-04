using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iStarosta.Content
{
    using global::iStarosta.Models;

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
                txtCourse.Text = news.Course.ToString();
                txtFacebook.Text = news.Facebook;
                txtFaculty.Text = news.Faculty;
                txtGroup.Text = news.Group.ToString();
                txtPhone.Text = news.Phone;
                txtCity.Text = news.City;
                txtSkype.Text = news.Skype;
                txtStatus.Text = news.Status;
                txtTwitter.Text = news.Twitter;
                txtVk.Text = news.Vk;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BsuUser news = BsuUser.GetByName(Page.User.Identity.Name);
            news.Birthday = txtBirthday.Text;
            news.Course = Convert.ToInt32(txtCourse.Text);
            news.Facebook = txtFacebook.Text;
            news.Faculty = txtFaculty.Text;
            news.Group = Convert.ToInt32(txtGroup.Text);
            news.Phone = txtGroup.Text;
            news.City = txtCity.Text;
            news.Skype = txtSkype.Text;
            news.Twitter = txtTwitter.Text;
            news.Vk = txtVk.Text;
            news.Status = txtStatus.Text;

            string path = AppDomain.CurrentDomain.BaseDirectory + "Design/img/avatars/";
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            if (filename != "")
            {
                FileUpload1.PostedFile.SaveAs(Path.Combine(path, filename));
            }
            else
            {
                filename = "default.png";
            }
            news.Image = filename;
            BsuUser.UpdateUser(news);
            Response.Redirect("/profile");
        }
    }
}