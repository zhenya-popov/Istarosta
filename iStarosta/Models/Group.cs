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
                SqlCommand command = new SqlCommand("SELECT * FROM group WHERE starostaid = @Id", connection);
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

        public static Group EnterData(SqlDataReader reader)
        {
            Group group = new Group();
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