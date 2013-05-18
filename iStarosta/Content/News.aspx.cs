using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;
using iStarosta.Providers;

namespace iStarosta.Content
{
    public partial class News : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.IsInRole("moderator") || User.IsInRole("admin"))
            {
                AddNewsLink.Visible = true;
            }
            List<Models.News> news = Models.News.GetNews();
            news.Reverse();
            ListView1.DataSource = news;
            ListView1.DataBind();
        }
    }
}