using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iStarosta.ContentForUser
{
    using global::iStarosta.Models;

    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Models.BsuUser user = Models.BsuUser.GetByName(Page.User.Identity.Name);
                if (user == null)
                {
                    Response.Redirect("/people");
                }

                txtBirthday.Text = user.Birthday;
                txtCourse.Text = user.Course.ToString();
                txtFacebook.Text = user.Facebook;
                txtFaculty.Text = user.Faculty;
                txtGroup.Text = user.Group.ToString();
                txtPhone.Text = user.Phone;
                txtCity.Text = user.City;
                txtSkype.Text = user.Skype;
                txtStatus.Text = user.Status;
                txtTwitter.Text = user.Twitter;
                txtVk.Text = user.Vk;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BsuUser user = BsuUser.GetByName(Page.User.Identity.Name);
            user.Birthday = txtBirthday.Text;
            user.Course = txtCourse.Text;
            user.Facebook = txtFacebook.Text;
            user.Faculty = txtFaculty.Text;
            user.Group = txtGroup.Text;
            user.Phone = txtGroup.Text;
            user.City = txtCity.Text;
            user.Skype = txtSkype.Text;
            user.Twitter = txtTwitter.Text;
            user.Vk = txtVk.Text;
            user.Status = txtStatus.Text;

            string path = AppDomain.CurrentDomain.BaseDirectory + "Design/img/avatars/";
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            if (filename != "")
            {
                FileUpload1.PostedFile.SaveAs(Path.Combine(path, filename));
            }
            else
            {
                if (user.Image != null)
                {
                    filename = user.Image;
                }
                else
                {
                    filename = "default.png";
                }
                
            }
            user.Image = filename;
            BsuUser.UpdateUser(user);
            Response.Redirect("/profile");
        }
    }
}