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
    public partial class AddAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Album album = new Album(){Name = TextBox1.Text};
            Album.AddAlbum(album);
            string path = AppDomain.CurrentDomain.BaseDirectory + "Design/img/photos";
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            if (filename != "")
            {
                FileUpload1.PostedFile.SaveAs(Path.Combine(path, filename));
                Photo photo = new Photo() { AlbumId = Album.GetAlbums().Last().Id, Name = filename };
                Photo.AddPhoto(photo);
            }
            
            Response.Redirect("/photo");
        }
    }
}