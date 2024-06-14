using NovelReadingApplication.Models;
using NovelReadingApplication.Services.Interfaces;
using System.Data.SqlClient;

namespace NovelReadingApplication.Services.Implementation
{
    public class NovelService
    {
        private DatabaseManager databaseManager;

        public NovelService(DatabaseManager databaseManager)
        {
            this.databaseManager = databaseManager;
        }

        //public List<Novel> GetAllNovels()
        //{
        //    List<Novel> novels = new List<Novel>();

        //    using (SqlConnection connection = databaseManager.GetConnection())
        //    {
        //        connection.Open();

        //        using (SqlCommand command = new SqlCommand("SELECT * FROM Novels", connection))
        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                novels.Add(new Novel
        //                {
        //                    Id = reader.GetInt32(0),
        //                    Title = reader.GetString(1),
        //                    Author = reader.GetString(2),
        //                    PublicationYear = reader.GetInt32(3),
        //                    SourceId = reader.GetInt32(4)
        //                });
        //            }
        //        }
        //    }

        //    return novels;
        //}
        //public void AddNovel(Novel novel)
        //{
        //    using (SqlConnection connection = databaseManager.GetConnection())
        //    {
        //        connection.Open();

        //        string sql = "INSERT INTO Novels (Title, Author, PublicationYear, SourceId) VALUES (@Title, @Author, @PublicationYear, @SourceId)";

        //        using (SqlCommand command = new SqlCommand(sql, connection))
        //        {
        //            command.Parameters.AddWithValue("@Title", novel.Title);
        //            command.Parameters.AddWithValue("@Author", novel.Author);
        //            command.Parameters.AddWithValue("@PublicationYear", novel.PublicationYear);
        //            command.Parameters.AddWithValue("@SourceId", novel.SourceId);

        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}
