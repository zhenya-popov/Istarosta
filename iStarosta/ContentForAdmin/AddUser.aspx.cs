using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.ContentForAdmin
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();

            BsuUser user = new BsuUser();
            user.Name = TextBox2.Text;
            user.Surname = TextBox3.Text;
            user.Patronymic = TextBox4.Text;
            user.Password = GetMd5Hash(md5Hash,TextBox5.Text);
            user.Group = TextBox6.Text;
            user.Course = TextBox7.Text;
            user.Faculty = TextBox8.Text;
            user.Role = TextBox9.Text;
            user.Email = TextBox10.Text;

            BsuUser.CreateUser(user);
        }

    }
}