using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VP_Project.Models;

namespace VP_Project.Controllers
{
    class DB_Queries
    {
        private MySqlDataReader executeQuery(String query)
        {
            Database.openConnection();
            var cmd = new MySqlCommand(query, Database.getConnection());
            MySqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }

        public User findUser(String email, String password)
        {
            string sql = "SELECT * FROM users";
            MySqlDataReader data = executeQuery(sql);

            User UserFromDB = new User();

            while (data.Read())
            {
                if (email == data.GetString(2) && password == data.GetString(3))
                {
                    UserFromDB.UserID = data.GetString(0);
                    UserFromDB.Name = data.GetString(1);
                    UserFromDB.Email = data.GetString(2);
                }
            }
            Database.closeConnection();

            return UserFromDB;
        }

        public void addUser(String name, String email, String password)
        {
            string sql = "INSERT INTO `users` (`name`,`email`, `pwd`) VALUES ('"+name+"','"+email+"','"+password+"')";
            MySqlDataReader data = executeQuery(sql);
            Database.closeConnection();
        }

        public List<Track> queryNewTracks()
        {
            string sql = "SELECT * FROM tracks ORDER BY track_id DESC LIMIT 3";
            MySqlDataReader data = executeQuery(sql);

            List<Track> new_tracks = new List<Track>();

            while (data.Read())
            {
                Track track = new Track();
                track.TrackID = data.GetString(0);
                track.Name = data.GetString(1);
                track.Artist = data.GetString(2);
                track.Duration = data.GetString(3);
                track.Cover_URL = data.GetString(4);
                track.URL = data.GetString(5);

                new_tracks.Add(track);
            }
            Database.closeConnection();

            return new_tracks;
        }

        public List<Playlist> retrievePlaylists()
        {
            string sql = "SELECT * FROM playlists WHERE user_id=" + Session.ActiveUserID;
            MySqlDataReader data = executeQuery(sql);

            List<Playlist> my_playlists = new List<Playlist>();

            while (data.Read())
            {
                Playlist playlist = new Playlist();
                playlist.PlaylistID = data.GetString(0);
                playlist.Name = data.GetString(1);
                playlist.NoOfTracks = data.GetString(2);
                playlist.Collaborator = data.GetString(4);

                my_playlists.Add(playlist);
            }
            Database.closeConnection();

            return my_playlists;
        }

        public void insertTrackInPlaylist(Playlist playlist, Track track)
        {
            string sql = "INSERT INTO `user_collections` (`playlist_id`,`track_id`) VALUES('"+playlist.PlaylistID+"','"+track.TrackID+"');";
            MySqlDataReader data = executeQuery(sql);
            Database.closeConnection();
        }
    }
}
