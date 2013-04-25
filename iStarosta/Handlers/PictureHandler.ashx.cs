using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace iStarosta.Handlers
{
    public class PictureHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string imgname = context.Request.QueryString["imagename"];
            String fileName = context.Server.MapPath("~/") + "App_Data/Images/" + imgname;
            try
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(fileName);

                int x = img.Width;
                int y = img.Height;
                double factor = 150f / x;

                Bitmap bm = new Bitmap(img, 150, Convert.ToInt32(factor * y));

                bm.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Gif);
                context.Response.Flush();
            }
            catch(Exception e)
            {
                
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}