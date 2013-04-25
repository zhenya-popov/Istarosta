using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace iStarosta.Models
{
    public class BsuInfo
    {
        public string About { get; set; }
        public string Clause { get; set; }
        public string Projects { get; set; }

        public static BsuInfo GetInfo()
        {
            SqlConnection connection = null;
            BsuInfo info = new BsuInfo();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM bsuinfo", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    info.About = reader["about"].ToString();
                    info.Clause = reader["clause"].ToString();
                    info.Projects = reader["projects"].ToString();
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
            return info;
        }
    }
}