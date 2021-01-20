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
        private Database DB;

        public DB_Queries()
        {
            DB = new Database();
        }

        private MySqlDataReader executeQuery(String query)
        {
            DB.openConnection();
            var cmd = new MySqlCommand(query, DB.getConnection());
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

            return UserFromDB;
        }

        public User loadUserDataFromDB(String ActiveUserID)
        {
            string sql = "SELECT * FROM users WHERE user_id=" + ActiveUserID;
            MySqlDataReader data = executeQuery(sql);

            User UserFromDB = new User();

            while (data.Read())
            {
                UserFromDB.UserID = data.GetString(0);
                UserFromDB.Name = data.GetString(1);
                UserFromDB.Email = data.GetString(2);
            }

            sql = "SELECT * FROM playlists WHERE user_id=" + ActiveUserID + " OR collaborator_id=" + ActiveUserID;
            data = executeQuery(sql);

            while (data.Read())
            {
                Playlist Playlist = new Playlist();
                Playlist.PlaylistID = data.GetString(0);
                Playlist.Name = data.GetString(1);
                Playlist.NoOfTracks = data.GetString(2);
                Playlist.Collaborator = data.GetString(4);

                string sql2 = "SELECT * FROM tracks INNER JOIN user_collections ON tracks.track_id = user_collections.track_id WHERE playlist_id=" + Playlist.PlaylistID;
                MySqlDataReader data2 = executeQuery(sql2);

                while(data2.Read())
                {
                    Track track = new Track();
                    track.TrackID = data2.GetString(0);
                    track.Name = data2.GetString(1);
                    track.Artist = data2.GetString(2);
                    track.Duration = data2.GetString(3);
                    track.Cover_URL = data2.GetString(4);
                    track.URL = data2.GetString(5);

                    Playlist.Tracks.Add(track);
                }

                UserFromDB.Playlists.Add(Playlist);
            }

            return UserFromDB;
        }

        public void addUser(String name, String email, String password)
        {
            string sql = "INSERT INTO `users` (`name`,`email`, `pwd`) VALUES ('"+name+"','"+email+"','"+password+"')";
            MySqlDataReader data = executeQuery(sql);
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

            return new_tracks;
        }

        public List<Playlist> retrievePlaylists(String ActiveUserID)
        {
            string sql = "SELECT * FROM playlists WHERE user_id=" + ActiveUserID;
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

            return my_playlists;
        }

        public List<Track> getSearchResults(String searchTerm)
        {
            string sql = "SELECT * from tracks WHERE locate('"+searchTerm+"', name)>0";
            MySqlDataReader data = executeQuery(sql);

            List<Track> search_results = new List<Track>();

            while (data.Read())
            {
                Track track = new Track();
                track.TrackID = data.GetString(0);
                track.Name = data.GetString(1);
                track.Artist = data.GetString(2);
                track.Duration = data.GetString(3);
                track.Cover_URL = data.GetString(4);
                track.URL = data.GetString(5);

                search_results.Add(track);
            }

            return search_results;
        }

        public void insertTrackInPlaylist(Playlist playlist, Track track)
        {
            string sql = "INSERT INTO `user_collections` (`playlist_id`,`track_id`) VALUES('"+playlist.PlaylistID+"','"+track.TrackID+"');";
            MySqlDataReader data = executeQuery(sql);

            int numTracks = int.Parse(playlist.NoOfTracks) + 1;

            // increment no of tracks
            sql = "UPDATE playlists SET no_of_tracks='" + numTracks + "' WHERE playlist_id=" + playlist.PlaylistID;
            data = executeQuery(sql);

            DB.closeConnection();
        }

        public void createNewPlaylist(String playlistName, String ActiveUserID)
        {
            string sql = "INSERT INTO `playlists` (`name`, `user_id`) VALUES('"+playlistName+"','"+ActiveUserID+"');";
            MySqlDataReader data = executeQuery(sql);
        }

        public String retrieveUserIdFromEmail(String email)
        {
            String userId = "";
            string sql = "SELECT user_id FROM users WHERE email='" + email + "';";
            MySqlDataReader data = executeQuery(sql);

            while(data.Read())
                userId = data.GetString(0);

            return userId;
        }

        public String retrieveUserEmailFromId(String userId)
        {
            String userEmail = "";
            string sql = "SELECT email FROM users WHERE user_id='" + userId+ "';";
            MySqlDataReader data = executeQuery(sql);

            while (data.Read())
                userEmail = data.GetString(0);

            return userEmail;
        }

        public void updateCollaborator(Playlist playlist, String userId)
        {
            string sql = "UPDATE playlists SET collaborator_id='" + userId + "' WHERE playlist_id=" + playlist.PlaylistID;
            MySqlDataReader data = executeQuery(sql);
        }

        public void removePlaylistFromDB(Playlist playlist)
        {
            string sql = "DELETE FROM playlists WHERE playlist_id=" + playlist.PlaylistID; // :'(
            MySqlDataReader data = executeQuery(sql);
        }
    }
}
