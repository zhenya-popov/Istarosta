using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.Content
{
    public partial class AlbumDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(User.IsInRole("admin") || User.IsInRole("moderator"))
            {
                FileUpload1.Visible = true;
                Button1.Visible = true;
            }
            List<Models.Photo> photos = Models.Photo.GetByAlbumId(Convert.ToInt32(Request.Params["postId"]));
            ListView1.DataSource = photos;
            ListView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Design/img/photos";
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            if (filename != "")
            {
                FileUpload1.PostedFile.SaveAs(Path.Combine(path, filename));
                Models.Photo photo = new Models.Photo() { AlbumId = Convert.ToInt32(Request.Params["postId"]), Name = filename };
                Models.Photo.AddPhoto(photo);
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}