using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace iStarosta.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Album> GetAlbums()
        {

            List<Album> albums = new List<Album>();
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM albums", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Album album = new Album();
                    album.Id = Convert.ToInt32(reader["id"]);
                    album.Name = reader["name"].ToString();
                    albums.Add(album);
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
            return albums;
        }

        public static bool AddAlbum(Album album)
        {
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO albums (name)" + " VALUES (@Name)", connection);
                SqlParameter name = new SqlParameter("@Name", album.Name);
                command.Parameters.Add(name);
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

        public static Album GetById(int Id)
        {
            Album album = null;
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM albums WHERE id=@Id", connection);
                SqlParameter paramId = new SqlParameter("@Id", Id);
                command.Parameters.Add(paramId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    album = new Album();
                    album.Id = Convert.ToInt32(reader["id"]);
                    album.Name = reader["name"].ToString();
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
            return album;
        }

        public static void UpdateAlbum(Album album)
        {
            SqlConnection connection = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE albums SET name=@Name WHERE id=@Id", connection);
                SqlParameter title = new SqlParameter("@Name", album.Name);
                command.Parameters.Add(title);
                SqlParameter parId = new SqlParameter("@Id", album.Id);
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

        public static bool DeleteAlbum(int id)
        {
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM albums WHERE id=@Id", connection);
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