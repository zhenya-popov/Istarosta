using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iStarosta.Content
{
    public partial class NewsDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Models.News news = Models.News.GetById(Convert.ToInt32(Request.Params["postId"]));
            if (news == null)
            {
                Response.Redirect("/news");
            }
            Label1.Text = news.Title;
            Label2.Text = news.Content;
            Image1.ImageUrl = "~/Handlers/PictureHandler.ashx?imageName=" + news.ImageName;
        }
    }
}