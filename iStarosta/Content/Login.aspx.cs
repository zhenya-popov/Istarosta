using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.Content
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            string pass = GetMd5Hash(md5Hash, TextBox2.Text);
            if (Membership.ValidateUser(TextBox1.Text, pass))
            {
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, true);
                
                HyperLink hl = (HyperLink) Master.FindControl("HyperLink1");
                hl.Visible = false;
                LinkButton lb = (LinkButton)Master.FindControl("LinkButton1");
                lb.Visible = true;
            }
            else
            {
                ErrorLbl.Text = "Credentials are incorrect. Please, try again";
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

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}