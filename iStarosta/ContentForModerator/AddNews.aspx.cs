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
    public partial class AddNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();

            if (FileUpload1.PostedFile.FileName != "")
            {
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/App_Data/Images/" + guid.ToString()));
                News.AddNews(TextBox1.Text, TextArea1.Value, guid.ToString(), "");
            }
            else
            {
                News.AddNews(TextBox1.Text, TextArea1.Value, "default.gif", "");
            }
            Response.Redirect("/news");
        }
    }
}