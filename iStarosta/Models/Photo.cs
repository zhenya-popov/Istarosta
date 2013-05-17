using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace iStarosta.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AlbumId { get; set; }

        public static bool AddPhoto(Photo photo)
        {
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO photos (name, albumId)" + " VALUES (@Name, @AlbumId)", connection);
                SqlParameter name = new SqlParameter("@Name", photo.Name);
                command.Parameters.Add(name);
                SqlParameter albumid = new SqlParameter("@AlbumId", photo.AlbumId);
                command.Parameters.Add(albumid);
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

        public static Photo GetById(int Id)
        {
            Photo photo = null;
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM photos WHERE id=@Id", connection);
                SqlParameter paramId = new SqlParameter("@Id", Id);
                command.Parameters.Add(paramId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    photo = new Photo();
                    photo.Id = Convert.ToInt32(reader["id"]);
                    photo.Name = reader["name"].ToString();
                    photo.AlbumId = Convert.ToInt32(reader["albumid"]);
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
            return photo;
        }

        public static List<Photo> GetByAlbumId(int id)
        {

            List<Photo> photos = new List<Photo>();
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM photos WHERE albumid = @Id", connection);
                SqlParameter paramId = new SqlParameter("@Id", id);
                command.Parameters.Add(paramId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Photo photo = new Photo();
                    photo.Id = Convert.ToInt32(reader["id"]);
                    photo.Name = reader["name"].ToString();
                    photo.AlbumId = Convert.ToInt32(reader["albumid"]);
                    photos.Add(photo);
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
            return photos;
        }
    }
}