using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MovieApi.Models
{
    public class MovieDBService
    {
        readonly string conStr = ConfigurationManager.ConnectionStrings["LIVEDNSfromLivedns"].ConnectionString;
        readonly string conStrLocal = ConfigurationManager.ConnectionStrings["LIVEDNSfromLocal"].ConnectionString;
        SqlConnection connection = null;
        SqlCommand command = null;
        readonly List<Movie> listMovie = new List<Movie>();
        readonly List<Serie> listSerie = new List<Serie>();
        readonly List<Anime> listAnime = new List<Anime>();
        readonly List<Favorie> listFavorie = new List<Favorie>();
        bool local = false;

        public void ConnectionOpen()
        {
            string cons = conStr;
            if (local)
            {
                cons = conStrLocal;
            }
            connection = new SqlConnection(cons);
            command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
        }


        public List<Movie> GetMoviesView()
        {
            ConnectionOpen();
            command.CommandText = "select * from Movie";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listMovie.Add(new Movie(Convert.ToInt32(reader["ID"]), (string)reader["Title"], (byte[])reader["Picture"], Convert.ToInt32(reader["Average"]), (string)reader["TextDescription"], (string)reader["Categorie"], (string)reader["Genre"], (string)reader["Link"]));
            }
            connection.Close();
            return listMovie;
        }
        public List<Serie> GetSeriesView()
        {
            ConnectionOpen();
            command.CommandText = "select * from Serie";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listSerie.Add(new Serie(Convert.ToInt32(reader["ID"]), (string)reader["Title"], (byte[])reader["Picture"], Convert.ToInt32(reader["Average"]), (string)reader["TextDescription"], (string)reader["Categorie"], Convert.ToInt32(reader["NbSeason"]), Convert.ToInt32(reader["NbEpisode"]), (string)reader["Genre"], (string)reader["Link"]));
            }
            connection.Close();
            return listSerie;
        }
        public List<Anime> GetAnimesView()
        {
            ConnectionOpen();
            command.CommandText = "select * from Anime";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listAnime.Add(new Anime(Convert.ToInt32(reader["ID"]), (string)reader["Title"], (byte[])reader["Picture"], Convert.ToInt32(reader["Average"]), (string)reader["TextDescription"], (string)reader["Categorie"], (string)reader["Genre"], (string)reader["Link"]));
            }
            connection.Close();
            return listAnime;
        }
        public List<Favorie> GetFavorieView()
        {
            ConnectionOpen();
            command.CommandText = "select * from Favorie";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listFavorie.Add(new Favorie(Convert.ToInt32(reader["ID"]), (string)reader["Title"], (byte[])reader["Picture"], (string)reader["Link"]));
            }
            connection.Close();
            return listFavorie;
        }



        public int PostMovieSave(Movie m)
        {          
            ConnectionOpen();
            command.CommandText = $"Insert into Movie (ID,Title,Picture,Average,TextDescription,Categorie,Genre,Link)" +
                        $"Values(@ID,@Title, @Picture ,@Average,@TextDescription,@Categorie,@Genre,@Link) ";

            command.Parameters.AddWithValue("@ID", m.ID);
            command.Parameters.AddWithValue("@Title", m.Title);
            command.Parameters.AddWithValue("@Picture", m.Picture);
            command.Parameters.AddWithValue("@Average", m.Average);
            command.Parameters.AddWithValue("@TextDescription", m.TextDescription);
            command.Parameters.AddWithValue("@Categorie", m.Categorie);
            command.Parameters.AddWithValue("@Genre", m.Genre);
            command.Parameters.AddWithValue("@Link", m.Link);


            int res = command.ExecuteNonQuery();
            command.Connection.Close();
            return res;
        }
        public int PostSerieSave(Serie s)
        {
            //,NbSeason,NBEpisode
            //@NbSeason,@NbEpisode
            //command.Parameters.AddWithValue("@NbSeason", m.NbSeason);
            //command.Parameters.AddWithValue("@NbEpisode", m.NbEpisode);
            ConnectionOpen();
            command.CommandText = $"Insert into Serie (ID,Title,Picture,Average,TextDescription,Categorie,NbSeason,NBEpisode,Genre,Link)" +
                        $"Values(@ID,@Title, @Picture ,@Average,@TextDescription,@Categorie,@NbSeason,@NbEpisode,@Genre,@Link) ";

            command.Parameters.AddWithValue("@ID", s.ID);
            command.Parameters.AddWithValue("@Title", s.Title);
            command.Parameters.AddWithValue("@Picture", s.Picture);
            command.Parameters.AddWithValue("@Average", s.Average);
            command.Parameters.AddWithValue("@TextDescription", s.TextDescription);
            command.Parameters.AddWithValue("@Categorie", s.Categorie);
            command.Parameters.AddWithValue("@NbSeason", s.NbSeason);
            command.Parameters.AddWithValue("@NbEpisode", s.NbEpisode);
            command.Parameters.AddWithValue("@Genre", s.Genre);
            command.Parameters.AddWithValue("@Link", s.Link);


            int res = command.ExecuteNonQuery();
            command.Connection.Close();
            return res;
        }
        public int PostAnimeSave(Anime a)
        {
            ConnectionOpen();
            command.CommandText = $"Insert into Anime (ID,Title,Picture,Average,TextDescription,Categorie,Genre,Link)" +
                        $"Values(@ID,@Title, @Picture ,@Average,@TextDescription,@Categorie,@Genre,@Link) ";

            command.Parameters.AddWithValue("@ID", a.ID);
            command.Parameters.AddWithValue("@Title", a.Title);
            command.Parameters.AddWithValue("@Picture", a.Picture);
            command.Parameters.AddWithValue("@Average", a.Average);
            command.Parameters.AddWithValue("@TextDescription", a.TextDescription);
            command.Parameters.AddWithValue("@Categorie", a.Categorie);
            command.Parameters.AddWithValue("@Genre", a.Genre);
            command.Parameters.AddWithValue("@Link", a.Link);


            int res = command.ExecuteNonQuery();
            command.Connection.Close();
            return res;
        }
        public int PostFavorieSave(Favorie f)
        {
            ConnectionOpen();
            command.CommandText = $"Insert into Favorie (ID,Title,Picture,Link)" +
                        $"Values(@ID,@Title,@Picture,@Link) ";

            command.Parameters.AddWithValue("@ID", f.ID);
            command.Parameters.AddWithValue("@Title", f.Title);
            command.Parameters.AddWithValue("@Picture", f.Picture);
            command.Parameters.AddWithValue("@Link", f.Link);

            int res = command.ExecuteNonQuery();
            command.Connection.Close();
            return res;
        }



        public Movie PutMovieUpdate(Movie m, int id)
        {
            // NbSeason =@NbSeason, NbEpisode = @NbEpisode
            //command.Parameters.Add(new SqlParameter("@NbSeason", m.NbSeason));
            //command.Parameters.Add(new SqlParameter("@NbEpisode", m.NbEpisode));
            ConnectionOpen();
            command.CommandText = "Update Movie" +
                            $" Set ID = @ID, Title=@Title, Average=@Average,Picture = @Picture, TextDescription=@TextDescription,Categorie=@Categorie , Genre=@Genre, Link =@Link" +
                          $" WHERE ID=@ID";


            command.Parameters.Add(new SqlParameter("@ID", m.ID));
            command.Parameters.Add(new SqlParameter("@Title", m.Title));
            command.Parameters.Add(new SqlParameter("@Picture", m.Picture));
            command.Parameters.Add(new SqlParameter("@Average", m.Average));
            command.Parameters.Add(new SqlParameter("@TextDescription", m.TextDescription));
            command.Parameters.Add(new SqlParameter("@Categorie", m.Categorie));
            command.Parameters.Add(new SqlParameter("@Genre", m.Genre));
            command.Parameters.Add(new SqlParameter("@Link", m.Link));

            command.ExecuteNonQuery();
            command.Connection.Close();
            m.ID = id;
            return m;
        }
        public Serie PutSerieUpdate(Serie s, int id)
        {
            // NbSeason =@NbSeason, NbEpisode = @NbEpisode
            //command.Parameters.Add(new SqlParameter("@NbSeason", m.NbSeason));
            //command.Parameters.Add(new SqlParameter("@NbEpisode", m.NbEpisode));
            ConnectionOpen();
            command.CommandText = "Update Serie" +
                            $" Set ID = @ID, Title=@Title, Average=@Average,Picture = @Picture, TextDescription=@TextDescription,Categorie=@Categorie,NbSeason =@NbSeason, NbEpisode = @NbEpisode , Genre=@Genre, Link =@Link" +
                          $" WHERE ID=@ID";


            command.Parameters.Add(new SqlParameter("@ID", s.ID));
            command.Parameters.Add(new SqlParameter("@Title", s.Title));
            command.Parameters.Add(new SqlParameter("@Picture", s.Picture));
            command.Parameters.Add(new SqlParameter("@Average", s.Average));
            command.Parameters.Add(new SqlParameter("@TextDescription", s.TextDescription));
            command.Parameters.Add(new SqlParameter("@Categorie", s.Categorie));
            command.Parameters.Add(new SqlParameter("@NbSeason", s.NbSeason));
            command.Parameters.Add(new SqlParameter("@NbEpisode", s.NbEpisode));
            command.Parameters.Add(new SqlParameter("@Genre", s.Genre));
            command.Parameters.Add(new SqlParameter("@Link", s.Link));

            command.ExecuteNonQuery();
            command.Connection.Close();
            s.ID = id;
            return s;
        }
        public Anime PutAnimeUpdate(Anime a, int id)
        {
            ConnectionOpen();
            command.CommandText = "Update Anime" +
                            $" Set ID = @ID, Title=@Title, Average=@Average,Picture = @Picture, TextDescription=@TextDescription,Categorie=@Categorie , Genre=@Genre, Link =@Link" +
                          $" WHERE ID=@ID";


            command.Parameters.Add(new SqlParameter("@ID", a.ID));
            command.Parameters.Add(new SqlParameter("@Title", a.Title));
            command.Parameters.Add(new SqlParameter("@Picture", a.Picture));
            command.Parameters.Add(new SqlParameter("@Average", a.Average));
            command.Parameters.Add(new SqlParameter("@TextDescription", a.TextDescription));
            command.Parameters.Add(new SqlParameter("@Categorie", a.Categorie));
            command.Parameters.Add(new SqlParameter("@Genre", a.Genre));
            command.Parameters.Add(new SqlParameter("@Link", a.Link));

            command.ExecuteNonQuery();
            command.Connection.Close();
            a.ID = id;
            return a;
        }



        public void DeleteMovieRemove(int id)
        {
            ConnectionOpen();
            command.CommandText = $"Delete from Movie Where ID = '{id}'";
            int res = command.ExecuteNonQuery();
            if (res == 0)
            {
#pragma warning disable S112 // General exceptions should never be thrown
                throw new Exception("The movie does not exist!");
#pragma warning restore S112 // General exceptions should never be thrown
            }
            command.Connection.Close();
        }
        public void DeleteSerieRemove(int id)
        {
            ConnectionOpen();
            command.CommandText = $"Delete from Serie Where ID = '{id}'";
            int res = command.ExecuteNonQuery();
            if (res == 0)
            {
#pragma warning disable S112 // General exceptions should never be thrown
                throw new Exception("The serie does not exist!");
#pragma warning restore S112 // General exceptions should never be thrown
            }
            command.Connection.Close();
        }
        public void DeleteAnimeRemove(int id)
        {
            ConnectionOpen();
            command.CommandText = $"Delete from Anime Where ID = '{id}'";
            int res = command.ExecuteNonQuery();
            if (res == 0)
            {
#pragma warning disable S112 // General exceptions should never be thrown
                throw new Exception("The anime does not exist!");
#pragma warning restore S112 // General exceptions should never be thrown
            }
            command.Connection.Close();
        }
        public void DeleteFavorieRemove(int id)
        {
            ConnectionOpen();
            command.CommandText = $"Delete from Favorie Where ID = '{id}'";
            int res = command.ExecuteNonQuery();
            if (res == 0)
            {
#pragma warning disable S112 // General exceptions should never be thrown
                throw new Exception("The favorie does not exist!");
#pragma warning restore S112 // General exceptions should never be thrown
            }
            command.Connection.Close();
        }



        public static string GetServerUrl()
        {
            var request = HttpContext.Current.Request;

            return request.Url.Scheme + "://" + request.Url.Authority + request.ApplicationPath.TrimEnd('/');
        }
    }
}