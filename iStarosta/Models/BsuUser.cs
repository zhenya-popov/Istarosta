using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace iStarosta.Models
{
    public class BsuUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Password { get; set; }
        public int Group { get; set; }
        public int Course { get; set; }
        public string Faculty { get; set; }
        public string Role { get; set; }

        public string Birthday { get; set; }
        public string Image { get; set; }
        public string City { get; set; }
        public string Status { get; set; }
        public string Phone { get; set; }
        public string Vk { get; set; }
        public string Facebook { get; set; }
        public string Skype { get; set; }
        public string Twitter { get; set; }

        public static List<BsuUser> GetUsers()
        {
            List<BsuUser> list = new List<BsuUser>();
            SqlConnection connection = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM users", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BsuUser bsuUser = BsuUser.EnterData(reader);
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

        public static BsuUser GetById(int Id)
        {
            SqlConnection connection = null;
            BsuUser bsuUser = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM users WHERE Id= @Id", connection);
                SqlParameter parId = new SqlParameter("@Id", Id);
                command.Parameters.Add(parId);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    bsuUser = BsuUser.EnterData(reader);
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
            return bsuUser;
        }

        public static void UpdateUser(BsuUser user)
        {
            SqlConnection connection = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE userinfo SET birthday=@Birthday,course=@Course, facebook=@Facebook," +
                                                    "faculty=@Faculty, phone=@Phone, group=@Group," +
                                                    "skype=@Skype, status=@Status, twitter=@Twitter," +
                                                    "city=@City WHERE id=@Id", connection);
                SqlParameter birthday = new SqlParameter("@Birthday", user.Birthday);
                command.Parameters.Add(birthday);
                SqlParameter course = new SqlParameter("@Course", user.Course);
                command.Parameters.Add(course);
                SqlParameter facebook = new SqlParameter("@Facebook", user.Facebook);
                command.Parameters.Add(facebook);
                SqlParameter faculty = new SqlParameter("@Faculty", user.Faculty);
                command.Parameters.Add(faculty);
                SqlParameter phone = new SqlParameter("@Phone", user.Phone);
                command.Parameters.Add(phone);
                SqlParameter group = new SqlParameter("@Group", user.Group);
                command.Parameters.Add(group);
                SqlParameter skype = new SqlParameter("@Skype", user.Skype);
                command.Parameters.Add(skype);
                SqlParameter status = new SqlParameter("@Status", user.Status);
                command.Parameters.Add(status);
                SqlParameter twitter = new SqlParameter("@Twitter", user.Twitter);
                command.Parameters.Add(twitter);
                SqlParameter city = new SqlParameter("@City", user.City);
                command.Parameters.Add(city);
                SqlParameter parId = new SqlParameter("@Id", user.Id);
                command.Parameters.Add(parId);
                command.ExecuteNonQuery();


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
        }

        public void ChangeInfo(int id, string password)
        {
            SqlConnection connection = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE users SET password=@Password WHERE id=@Id", connection);
                SqlParameter parPass = new SqlParameter("@Password", password);
                command.Parameters.Add(parPass);
                SqlParameter parId = new SqlParameter("@Id", id);
                command.Parameters.Add(parId);
                command.ExecuteNonQuery();


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
        }

        public static BsuUser GetByName(string name)
        {
            SqlConnection connection = null;
            BsuUser bsuUser = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM users WHERE email= @Email", connection);
                SqlParameter parName = new SqlParameter("@Email", name);
                command.Parameters.Add(parName);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    bsuUser = BsuUser.EnterData(reader);
                }
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
            return bsuUser;
        }

        public static bool CreateUser(BsuUser user)
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

                SqlCommand command = new SqlCommand("INSERT INTO users (userid, email, surname, patronymic, password, studygroup, course, faculty, role, status, image)" +
                                                    " VALUES (@Email, @Name, @Surname, @Patronymic, @Password, @Studygroup, @Course, @Faculty, @Role, @Status, @Image)", connection);

                string role = (user.Role == "") ? "user" : user.Role;
                SqlParameter parRole = new SqlParameter("@Role", role);
                command.Parameters.Add(parRole);
                SqlParameter email = new SqlParameter("@Email", user.Email);
                command.Parameters.Add(email);
                SqlParameter name = new SqlParameter("@Name", user.Name);
                command.Parameters.Add(name);
                SqlParameter surname = new SqlParameter("@Surname", user.Surname);
                command.Parameters.Add(surname);
                SqlParameter patronymic = new SqlParameter("@Patronymic", user.Patronymic);
                command.Parameters.Add(patronymic);
                SqlParameter parPassword = new SqlParameter("@Password", user.Password);
                command.Parameters.Add(parPassword);
                SqlParameter studyGroup = new SqlParameter("@StudyGroup", user.Group);
                command.Parameters.Add(studyGroup);
                SqlParameter course = new SqlParameter("@Course", user.Course);
                command.Parameters.Add(course);
                SqlParameter faculty = new SqlParameter("@Faculty", user.Faculty);
                command.Parameters.Add(faculty);
                SqlParameter status = new SqlParameter("@Status", user.Status);
                command.Parameters.Add(status);
                SqlParameter img = new SqlParameter("@Image", user.Image);
                command.Parameters.Add(img);
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
            BsuUser newUser = GetByName(user.Name);
            if (newUser != null && user.Password == newUser.Password)
                return true;
            return false;
        }

        public static BsuUser EnterData(SqlDataReader reader)
        {
            BsuUser bsuUser = new BsuUser();
            bsuUser.Id = Convert.ToInt32(reader["id"]);
            bsuUser.Email = reader["email"].ToString();
            bsuUser.Name = reader["name"].ToString();
            bsuUser.Surname = reader["surname"].ToString();
            bsuUser.Patronymic = reader["patronymic"].ToString();
            bsuUser.Group = Convert.ToInt32(reader["studygroup"]);
            bsuUser.Course = Convert.ToInt32(reader["course"]);
            bsuUser.Faculty = reader["faculty"].ToString();
            bsuUser.Password = reader["password"].ToString();
            bsuUser.Role = reader["role"].ToString();

            bsuUser.Birthday = reader["birthday"].ToString();
            bsuUser.City = reader["city"].ToString();
            bsuUser.Status = reader["status"].ToString();
            bsuUser.Phone = reader["phone"].ToString();
            bsuUser.Vk = reader["vk"].ToString();
            bsuUser.Facebook = reader["facebook"].ToString();
            bsuUser.Skype = reader["skype"].ToString();
            bsuUser.Twitter = reader["twitter"].ToString();
            bsuUser.Image = reader["image"].ToString();


            return bsuUser;
        }
    }
}