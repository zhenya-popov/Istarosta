using System;
using System.Collections.Generic;
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
                txtStatus.Text = news.Skype;
                txtTwitter.Text = news.Twitter;
                txtVk.Text = news.Vk;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BsuUser news = BsuUser.GetById(Convert.ToInt32(Request.Params["postId"]));
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
            BsuUser.UpdateUser(news);
            Response.Redirect("/news");
        }
    }
}