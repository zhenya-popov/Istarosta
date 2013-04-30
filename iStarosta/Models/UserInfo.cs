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

        public static bool CreateUser(UserInfo user)
        {
            SqlConnection connection = null;

            if (user == null)
            {
                return false;
            }

            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO userinfo (phonenumber, vkontakte, skype, imagelink, name, " +
                           "surname, patronymic, email, course, faculty, position)" +
                           " VALUES (@Phonenumber, @Vkontakte, @Skype, @Imagelink, @Name, @Surname, @Patronymic, @Email," +
                            " @Course, @Faculty, @Position)", connection);
                SqlParameter number = new SqlParameter("@Phonenumber", user.PhoneNumber);
                command.Parameters.Add(number);
                SqlParameter vk = new SqlParameter("@Vkontakte", user.Vkontakte);
                command.Parameters.Add(vk);
                SqlParameter skype = new SqlParameter("@Skype", user.Skype);
                command.Parameters.Add(skype);
                SqlParameter img = new SqlParameter("@Imagelink", user.ImageLink);
                command.Parameters.Add(img);
                SqlParameter name = new SqlParameter("@Name", user.Name);
                command.Parameters.Add(name);
                SqlParameter surname = new SqlParameter("@Surname", user.Surname);
                command.Parameters.Add(surname);
                SqlParameter patronymic = new SqlParameter("@Patronymic", user.Patronymic);
                command.Parameters.Add(patronymic);
                SqlParameter email = new SqlParameter("@Email", user.Email);
                command.Parameters.Add(email);            
                SqlParameter course = new SqlParameter("@Course", user.Course);
                command.Parameters.Add(course);
                SqlParameter faculty = new SqlParameter("@Faculty", user.Faculty);
                command.Parameters.Add(faculty);
                SqlParameter position = new SqlParameter("@Position", user.Position);
                command.Parameters.Add(position);
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return true;
        }

        public static bool DeleteUser(int Id)
        {
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM userinfo WHERE id=@Id", connection);
                SqlParameter user = new SqlParameter("@Id", Id);
                command.Parameters.Add(user);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return true;
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