using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.ContentForModerator
{
    public partial class EditNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                News news = News.GetById(Convert.ToInt32(Request.Params["postId"]));
                if (news == null)
                {
                    Response.Redirect("/news");
                }
                TextArea1.InnerText = news.Title;
                TextArea1.InnerText = news.Content;
                Image1.ImageUrl = "~/Handlers/PictureHandler.ashx?imageName=" + news.ImageName;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            News news = News.GetById(Convert.ToInt32(Request.Params["postId"]));
            news.Title = TextBox1.Text;
            news.Content = TextArea1.InnerText;
            News.UpdateNews(news);
            Response.Redirect("/news");
        }
    }
}