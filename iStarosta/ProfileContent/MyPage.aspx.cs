using System;
using System.Collections.Generic;
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
        }
    }
}