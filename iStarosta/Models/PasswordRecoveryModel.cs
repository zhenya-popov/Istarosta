using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace iStarosta.Models
{
    public class PasswordRecoveryModel
    {
        public int Userid { get; set; }
        public string Identifier { get; set; }


        public static int GetUserId(string identifier)
        {
            SqlConnection connection = null;
            int id = 0;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT userid FROM passwordRecovery WHERE uid= @Identifier", connection);
                SqlParameter parId = new SqlParameter("@Identifier", identifier);
                command.Parameters.Add(parId);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["userid"]);
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
            return id;
        }

        public static bool AddRecord(int id, string identifier)
        {
            SqlConnection connection = null;

            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO passwordRecovery (userid, uid)" +
                                                    " VALUES (@Userid, @Uid)", connection);

                SqlParameter parId = new SqlParameter("@Userid", id);
                command.Parameters.Add(parId);
                SqlParameter uid = new SqlParameter("@Uid", identifier);
                command.Parameters.Add(uid);
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

        public static bool DeleteRecord(int id)
        {
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM passwordRecovery WHERE userid=@Id", connection);
                SqlParameter record = new SqlParameter("@Id", id);
                command.Parameters.Add(record);
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