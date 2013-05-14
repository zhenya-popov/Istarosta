using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iStarosta.Models
{
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;

    public class Messages
    {
        public string Sender { get; set; }
        public string Addressee { get; set; }
        public string Message { get; set; }

        public static List<Messages> GetMessages()
        {
            List<Messages> list = new List<Messages>();
            SqlConnection connection = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [Message]", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Messages bsuUser = Messages.EnterData(reader);
                    list.Add(bsuUser);
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return list;
        }

        public static Messages EnterData(SqlDataReader reader)
        {
            Messages bsuUser = new Messages();
            bsuUser.Sender = reader["sender"].ToString();
            bsuUser.Addressee = reader["addressee"].ToString();
            bsuUser.Message = reader["message"].ToString();

            return bsuUser.Addressee == HttpContext.Current.User.Identity.Name ?  bsuUser : null;
        }

        public static void Send(Messages message)
        {
            SqlConnection connection = null;

            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO [Message] (sender, addressee, messagetext) VALUES (@Sender, @Addressee, @Msgtext)", connection);

                SqlParameter sender = new SqlParameter("@Sender", message.Sender);
                command.Parameters.Add(sender);
                SqlParameter adrdresse = new SqlParameter("@Addressee", message.Addressee);
                command.Parameters.Add(adrdresse);
                SqlParameter msg = new SqlParameter("@Msgtext", message.Message);
                command.Parameters.Add(msg);

                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }
    }
}