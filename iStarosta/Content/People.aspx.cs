﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.Content
{

    public partial class People : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.IsInRole("moderator") || User.IsInRole("admin"))
            {
                AddUserLink.Visible = true;
            }
        }
    }
}