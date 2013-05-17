using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace iStarosta.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static List<Project> GetNews()
        {

            List<Project> projects = new List<Project>();
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM projects", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Project project = new Project();
                    project.Id = Convert.ToInt32(reader["id"]);
                    project.Name = reader["name"].ToString();
                    project.Description = reader["description"].ToString();
                    projects.Add(project);
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
            return projects;
        }

        public static bool AddProject(Project project)
        {
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO projects (name, description)" + " VALUES (@Name, @Description)", connection);
                SqlParameter name = new SqlParameter("@Name", project.Name);
                command.Parameters.Add(name);
                SqlParameter description = new SqlParameter("@Description", project.Description);
                command.Parameters.Add(description);
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

        public static Project GetById(int Id)
        {
            Project project = null;
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM projects WHERE id=@Id", connection);
                SqlParameter paramId = new SqlParameter("@Id", Id);
                command.Parameters.Add(paramId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    project = new Project();
                    project.Id = Convert.ToInt32(reader["id"]);
                    project.Name = reader["name"].ToString();
                    project.Description = reader["description"].ToString();
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
            return project;
        }

        public static void UpdateProject(Project project)
        {
            SqlConnection connection = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE projects SET name=@Name, description=@Description WHERE id=@Id", connection);
                SqlParameter title = new SqlParameter("@Name", project.Name);
                command.Parameters.Add(title);
                SqlParameter content = new SqlParameter("@Description", project.Description);
                command.Parameters.Add(content);
                SqlParameter parId = new SqlParameter("@Id", project.Id);
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

        public static bool DeleteProject(int id)
        {
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM projects WHERE id=@Id", connection);
                SqlParameter parBook = new SqlParameter("@Id", id);
                command.Parameters.Add(parBook);
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
    }
}