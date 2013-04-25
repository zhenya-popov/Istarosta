using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace iStarosta.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageName { get; set; }
        public string YoutubeLink { get; set; }
        public string PostDate { get; set; }
        
        public static bool AddNews(string title, string content, string imageName, string youtubeLink)
        {
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO news (title, newscontent, imagename, youtubelink, postdate)" +
                                                    " VALUES (@Title, @Newscontent, @Imagename, @Youtubelink, @Postdate)", connection);
                SqlParameter parTitle = new SqlParameter("@Title", title);
                command.Parameters.Add(parTitle);
                SqlParameter parContent = new SqlParameter("@Newscontent", content);
                command.Parameters.Add(parContent);
                SqlParameter parImgName = new SqlParameter("@Imagename", imageName);
                command.Parameters.Add(parImgName);
                SqlParameter parLink = new SqlParameter("@Youtubelink", youtubeLink);
                command.Parameters.Add(parLink);
                SqlParameter parDate = new SqlParameter("@Postdate", DateTime.Now);
                command.Parameters.Add(parDate);
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

        public static List<News> GetNews()
        {

            List<News> NewsList = new List<News>();
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM news", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    News news = new News();
                    news.Id = Convert.ToInt32(reader["id"]);
                    news.Title = reader["title"].ToString();
                    news.Content = reader["newscontent"].ToString();
                    news.ImageName = reader["imagename"].ToString();
                    news.YoutubeLink = reader["youtubelink"].ToString();
                    news.YoutubeLink = reader["postdate"].ToString();
                    NewsList.Add(news);
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
            return NewsList;
        }

        public static News GetById(int Id)
        {
            News news = null;
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM news WHERE id=@Id", connection);
                SqlParameter paramId = new SqlParameter("@Id", Id);
                command.Parameters.Add(paramId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    news = new News();
                    news.Id = Convert.ToInt32(reader["id"]);
                    news.Title = reader["title"].ToString();
                    news.Content = reader["newscontent"].ToString();
                    news.ImageName = reader["imagename"].ToString();
                    news.YoutubeLink = reader["youtubelink"].ToString();
                    news.YoutubeLink = reader["postdate"].ToString();
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
            return news;
        }

        public static void UpdateNews(News news)
        {
            SqlConnection connection = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE news SET title=@Title, newscontent=@Newscontent WHERE id=@Id", connection);
                SqlParameter title = new SqlParameter("@Title", news.Title);
                command.Parameters.Add(title);
                SqlParameter content = new SqlParameter("@Newscontent", news.Content);
                command.Parameters.Add(content);
                SqlParameter parId = new SqlParameter("@Id", news.Id);
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

        public static bool DeleteNews(int NewsId)
        {
            SqlConnection connection = null;
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                connection = new SqlConnection(ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM news WHERE id=@NewsId", connection);
                SqlParameter parBook = new SqlParameter("@BookId", NewsId);
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