using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstMVCApp.Models
{
    public class MovieDbRepository
    {
        public static List<Movie> GetMovieList()
        {
            List<Movie> list = new List<Movie>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectMoviecmd = cn.CreateCommand();
                String selectAllMovie = "Select * from Movie";
                selectMoviecmd.CommandText = selectAllMovie;
                SqlDataReader Moviedr = selectMoviecmd.ExecuteReader();
                while (Moviedr.Read())
                {
                    Movie movie = new Movie
                    {
                        Id = Moviedr.GetDecimal(0),
                        Title = Moviedr.GetString(1),
                        Language = Moviedr.GetString(2),
                        Hero = Moviedr.GetString(3),
                        Director = Moviedr.GetString(4),
                        MusicDirector = Moviedr.GetString(5),
                        ReleasedDate = Moviedr.GetDateTime(6),
                        Cost = Moviedr.GetDecimal(7),
                        Collection = Moviedr.GetDecimal(8),
                        Review = Moviedr.GetString(9)
                    };
                    list.Add(movie);
                }
            }
            return list;
        }
        public static Movie GetMovieById(int Id)
        {
            Movie movieFound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                { cn.Open(); }
                SqlCommand selectMoviecmd = cn.CreateCommand();
                String selectAllMovie = "Select * from Movie";
                selectMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                selectMoviecmd.CommandText = selectAllMovie;
                SqlDataReader Moviedr = selectMoviecmd.ExecuteReader();
               
                    while (Moviedr.Read())

                    movieFound = new Movie
                    {

                        Id = Moviedr.GetInt32(0),
                        Title = Moviedr.GetString(1),
                        Language = Moviedr.GetString(2),
                        Hero = Moviedr.GetString(3),
                        Director = Moviedr.GetString(4),
                        MusicDirector = Moviedr.GetString(5),
                        ReleasedDate = Moviedr.GetDateTime(6),
                        Cost = Moviedr.GetInt32(7),
                        Collection = Moviedr.GetInt32(8),
                        Review = Moviedr.GetString(9)
                    };



            }
            return movieFound;

        }
        public static int AddNewMovie(Movie newMovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertMoviecmd = cn.CreateCommand();
                String insertNewMovieQuery = "insert into Movie values( @ID,@Title,@Language,@Hero,@Director,@MusicDirector,@ReleasedDate,@Cost,@Collection,@Review) )";
                insertMoviecmd.Parameters.Add("@ID", SqlDbType.Int).Value = newMovie.Id;
                insertMoviecmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = newMovie.Title;
                insertMoviecmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = newMovie.Language;
                insertMoviecmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = newMovie.Hero;
                insertMoviecmd.Parameters.Add("@Director", SqlDbType.NVarChar).Value = newMovie.Director;
                insertMoviecmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = newMovie.MusicDirector;
                insertMoviecmd.Parameters.Add("@ReleasedDate", SqlDbType.DateTime).Value = newMovie.ReleasedDate;
                insertMoviecmd.Parameters.Add("@Cost", SqlDbType.Int).Value = newMovie.Cost;
                insertMoviecmd.Parameters.Add("@Collection", SqlDbType.Int).Value = newMovie.Collection;
                insertMoviecmd.Parameters.Add("@Review", SqlDbType.NVarChar).Value = newMovie.Review;
                insertMoviecmd.CommandText = insertNewMovieQuery;
                query_result = insertMoviecmd.ExecuteNonQuery();
            }
            return query_result;

        }
        public static int UpdateMovie(Movie ModifiMovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand UpdateMoviecmd = cn.CreateCommand();
                String UpdateNewMovieQuery = "insert into Movie values( @ID,@Title,@Language,@Hero,@Director,@MusicDirector,@ReleasedDate,@Cost,@Collection,@Review) )";
                UpdateMoviecmd.Parameters.Add("@ID", SqlDbType.Int).Value =  ModifiMovie.Id;
                UpdateMoviecmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value =  ModifiMovie.Title;
                UpdateMoviecmd.Parameters.Add("@Language", SqlDbType.Decimal).Value =  ModifiMovie.Language;
                UpdateMoviecmd.Parameters.Add("@Hero", SqlDbType.NVarChar).Value =  ModifiMovie.Hero;
                UpdateMoviecmd.Parameters.Add("@Director", SqlDbType.Int).Value =  ModifiMovie.Director;
                UpdateMoviecmd.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value =  ModifiMovie.MusicDirector;
                UpdateMoviecmd.Parameters.Add("@ReleasedDate", SqlDbType.Decimal).Value =  ModifiMovie.ReleasedDate;
                UpdateMoviecmd.Parameters.Add("@Cost", SqlDbType.NVarChar).Value =  ModifiMovie.Cost;
                UpdateMoviecmd.Parameters.Add("@Collection", SqlDbType.Decimal).Value =  ModifiMovie.Collection;
                UpdateMoviecmd.Parameters.Add("@Review", SqlDbType.NVarChar).Value =  ModifiMovie.Review;
                UpdateMoviecmd.CommandText = UpdateNewMovieQuery;
                query_result = UpdateMoviecmd.ExecuteNonQuery();
            }
            return query_result;

        }
        public static int DeleteMovie(int Id)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteMoviecmd = cn.CreateCommand();
                String deleteMovieQuery = "Delete from Movie where ID=@id";
                deleteMoviecmd.Parameters.Add("@ID", SqlDbType.Int).Value = Id;
                deleteMoviecmd.CommandText = deleteMovieQuery;
                query_result = deleteMoviecmd.ExecuteNonQuery();
            }
            return query_result;

        }

    }
}
