using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.PasswordRecovery
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string identifier = Request.QueryString["uid"];
            int id = PasswordRecoveryModel.GetUserId(identifier);
            BsuUser user = BsuUser.GetById(id);
            if (user == null)
            {
                Response.Redirect("/news");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == TextBoxConfirm.Text)
            {
                string identifier = Request.QueryString["uid"];
                int id = PasswordRecoveryModel.GetUserId(identifier);
                BsuUser user = BsuUser.GetById(id);
                MD5 md5Hash = MD5.Create();
                string newPassword = GetMd5Hash(md5Hash, TextBoxPassword.Text);

                user.ChangeInfo(user.Id, newPassword);
                PasswordRecoveryModel.DeleteRecord(user.Id);

                Label1.Text = "Password was successfully changed";
            }
            else
            {
                Label1.Text = "passwords doesn't match";
            }
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}