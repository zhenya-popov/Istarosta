using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace iStarosta.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Vkontakte { get; set; }
        public string Skype { get; set; }
        public string ImageLink { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public string Faculty { get; set; }
        public string Position { get; set; }


        public static List<UserInfo> GetUsers()
        {
            List<UserInfo> list = new List<UserInfo>();
            SqlConnection connection = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM userinfo", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UserInfo bsuUser = UserInfo.EnterData(reader);
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

        public static UserInfo EnterData(SqlDataReader reader)
        {
            UserInfo info = new UserInfo();
            info.Id = Convert.ToInt32(reader["id"]);
            info.PhoneNumber = reader["phonenumber"].ToString();
            info.Vkontakte = reader["vkontakte"].ToString();
            info.Skype = reader["skype"].ToString();
            info.ImageLink = reader["imagelink"].ToString();
            info.Name = reader["name"].ToString();
            info.Surname = reader["surname"].ToString();
            info.Patronymic = reader["patronymic"].ToString();
            info.Email = reader["email"].ToString();
            info.Course = Convert.ToInt32(reader["course"]);
            info.Faculty = reader["faculty"].ToString();
            info.Position = reader["position"].ToString();

            return info;
        }
    }
}