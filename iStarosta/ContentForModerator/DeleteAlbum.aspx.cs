using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.ContentForModerator
{
    public partial class DeleteAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Album album = Album.GetById(Convert.ToInt32(Request.Params["postId"]));
            if(album!=null)
            {
                Album.DeleteAlbum(album.Id);
            }
            Response.Redirect("/photo");
        }
    }
}