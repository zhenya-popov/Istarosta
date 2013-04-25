using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iStarosta.Models;

namespace iStarosta.PasswordRecovery
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ResetButton_Click(object sender, EventArgs e)
        {
            BsuUser user = BsuUser.GetByName(TextBoxName.Text);
            if (user != null)
            {
                Guid guid = Guid.NewGuid();
                PasswordRecoveryModel.AddRecord(user.Id, guid.ToString());
                SendPasswordResetEmail(user.Email, guid.ToString());
                LabelMessage.Text = "Email was sent";
            }
            else
            {
                LabelMessage.Text = "User wasn't found";
            }
        }

        private void SendPasswordResetEmail(string toEmail, string uid)
        {
            MailMessage mailMessage = new MailMessage("test@gmail.com", toEmail);
            StringBuilder sb = new StringBuilder();

            sb.Append("http://localhost:63542/PasswordRecovery/ChangePassword.aspx?uid=" + uid);

            mailMessage.IsBodyHtml = true;
            mailMessage.Body = sb.ToString();
            mailMessage.Subject = "Forgot your password";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential()
            {
                //waiting for bsu email
                UserName = "test@gmail.com",
                Password = "testtest"
            };

            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }
    }
}