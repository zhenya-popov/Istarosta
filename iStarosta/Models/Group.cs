using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace iStarosta.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string StarostaId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public static List<Group> GetGroup()
        {
            List<Group> list = new List<Group>();
            SqlConnection connection = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                string id = HttpContext.Current.User.Identity.Name;
                SqlCommand command = new SqlCommand("SELECT * FROM [group] WHERE starostaid = @Id", connection);
                SqlParameter parName = new SqlParameter("@Id", id);
                command.Parameters.Add(parName);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Group user = Group.EnterData(reader);
                    list.Add(user);
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

        public static Group GetById(int Id)
        {
            SqlConnection connection = null;
            Group user = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [group] WHERE Id= @Id", connection);
                SqlParameter parId = new SqlParameter("@Id", Id);
                command.Parameters.Add(parId);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user = Group.EnterData(reader);
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
            return user;
        }

        public static void UpdateInfo(Group info)
        {
            SqlConnection connection = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE [group] SET name=@Name,surname=@Surname, patronymic=@Patronymic," +
                                                    "phone=@Phone, email=@Email WHERE id=@Id", connection);
                SqlParameter name = new SqlParameter("@Name", info.Name);
                command.Parameters.Add(name);
                SqlParameter surname = new SqlParameter("@Surname", info.Surname);
                command.Parameters.Add(surname);
                SqlParameter patronymic = new SqlParameter("@Patronymic", info.Patronymic);
                command.Parameters.Add(patronymic);
                SqlParameter email = new SqlParameter("@Email", info.Email);
                command.Parameters.Add(email);
                SqlParameter number = new SqlParameter("@Phone", info.Phone);
                command.Parameters.Add(number);
                SqlParameter id = new SqlParameter("@Id", info.Id);
                command.Parameters.Add(id);
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

        public static bool AddToGroup(Group user)
        {
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO [group] (starostaid, name, surname, patronymic, phone," +
                                                    " email) VALUES (@Id, @Name, @Surname, @Patronymic, @Phone, @Email)", connection);
                SqlParameter id = new SqlParameter("@Id", HttpContext.Current.User.Identity.Name);
                command.Parameters.Add(id);
                SqlParameter name = new SqlParameter("@Name", user.Name);
                command.Parameters.Add(name);
                SqlParameter surname = new SqlParameter("@Surname", user.Surname);
                command.Parameters.Add(surname);
                SqlParameter patronymic = new SqlParameter("@Patronymic", user.Patronymic);
                command.Parameters.Add(patronymic);
                SqlParameter phone = new SqlParameter("@Phone", user.Phone);
                command.Parameters.Add(phone);
                SqlParameter email = new SqlParameter("@Email", user.Email);
                command.Parameters.Add(email);
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
            return true;
        }

        public static bool DeleteFromGroup(int Id)
        {
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM [group] WHERE id=@Id", connection);
                SqlParameter id = new SqlParameter("@Id", Id);
                command.Parameters.Add(id);
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

        public static Group EnterData(SqlDataReader reader)
        {
            Group group = new Group();
            group.Id = Convert.ToInt32(reader["id"]);
            group.StarostaId = reader["starostaid"].ToString();
            group.Name = reader["name"].ToString();
            group.Surname = reader["surname"].ToString();
            group.Patronymic = reader["patronymic"].ToString();
            group.Phone = reader["phone"].ToString();
            group.Email = reader["email"].ToString();
            return group;
        }
    }

    
}