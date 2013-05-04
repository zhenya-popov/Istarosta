﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.Enter
{
    public partial class MyPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BsuUser user = BsuUser.GetByName(Page.User.Identity.Name);
            NameLabel.Text = user.Name;
            SurnameLabel.Text = user.Surname;
            FacultyLabel.Text = user.Faculty;
            BirthdayLabel.Text = user.Birthday;
            CityLabel.Text = user.City;
            PositionLabel.Text = user.Status;
            CourseLabel.Text = user.Course.ToString();
            GroupLabel.Text = user.Group.ToString();
            PhoneLabel.Text = user.Phone;
            VkLabel.Text = user.Vk;
            FacebookLabel.Text = user.Facebook;
            SkypeLabel.Text = user.Skype;
            TwitterLabel.Text = user.Twitter;
        }

        protected void FileUpload1_Load(object sender, EventArgs e)
        {

        }

        protected void FileUpload1_DataBinding(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Design/img/avatars";
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            if (filename != "")
            {
                FileUpload1.PostedFile.SaveAs(Path.Combine(path, filename));
            }
            else
            {
                filename = "default.png";
            }

            BsuUser user = BsuUser.GetByName(Page.User.Identity.Name);
            
        }
    }
}