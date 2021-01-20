using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Project.Models;

namespace VP_Project.Controllers
{
    public class Operations
    {
        private Database DB;
        private DB_Queries DBQ;

        public Operations()
        {
            DB = new Database();
            DBQ = new DB_Queries();
        }

        public bool trySignIn(String email, String password)
        {
            bool success = false;

            DB.openConnection();
            if (DB.isConnOpen())
            {
                User user = DBQ.findUser(email, password);

                if (email == user.Email)
                {
                    Session.ActiveUser.UserID = user.UserID;
                    Session.ActiveUser.Name = user.Name;
                    Session.ActiveUser.Email = user.Email;
                    success = true;
                }

                DB.closeConnection();
            }
            else
            {
                MessageBox.Show("Could not establish connection with the database.", "Error");
            }

            return success;
        }

        public bool signUp(String name, String email, String password)
        {
            bool success = false;

            DB.openConnection();
            if (DB.isConnOpen())
            {
                DBQ.addUser(name, email, password);

                User user = DBQ.findUser(email, password);
                if (email == user.Email)
                    success = true;

                DB.closeConnection();
            }
            else
            {
                MessageBox.Show("Could not establish connection with the database.", "Error");
            }

            return success;
        }

        public void signOut()
        {
            Session.ActiveUser = new User();
            Session.NowPlaying = new Track();
            Session.ErrProv.Clear();
        }

        public void loadUserData()
        {
            DB.openConnection();
            if (DB.isConnOpen())
            {
                Session.ActiveUser = DBQ.loadUserDataFromDB(Session.ActiveUser.UserID);
                DB.closeConnection();
            }
            else
                MessageBox.Show("Could not establish connection with the database.", "Error");
        }

        public List<Track> loadNewTracks()
        {
            List<Track> new_tracks = new List<Track>();

            DB.openConnection();
            if (DB.isConnOpen())
            {
                new_tracks = DBQ.queryNewTracks();
                DB.closeConnection();
            }
            else
                MessageBox.Show("Could not establish connection with the database.", "Error");

            return new_tracks;
        }

        public List<Playlist> getPlaylists()
        {
            List<Playlist> my_playlists = new List<Playlist>();
            
            DB.openConnection();
            if (DB.isConnOpen())
            {
                my_playlists = DBQ.retrievePlaylists(Session.ActiveUser.UserID);
                DB.closeConnection();
            }
            else
                MessageBox.Show("Could not establish connection with the database.", "Error");

            return my_playlists;
        }

        public List<Track> searchTrack(String searchTerm)
        {
            List<Track> search_results = new List<Track>();

            DB.openConnection();
            if (DB.isConnOpen())
            {
                search_results = DBQ.getSearchResults(searchTerm);
                DB.closeConnection();
            }
            else
                MessageBox.Show("Could not establish connection with the database.", "Error");

            return search_results;
        }

        public void addTrackToPlaylist(Playlist playlist, Track track)
        {
            DB.openConnection();
            if (DB.isConnOpen())
            {
                DBQ.insertTrackInPlaylist(playlist, track);
                DB.closeConnection();
            }
            else
                MessageBox.Show("Could not establish connection with the database.", "Error");
        }

        public void createPlaylist(String playlistName)
        {
            DB.openConnection();
            if (DB.isConnOpen())
            {
                DBQ.createNewPlaylist(playlistName, Session.ActiveUser.UserID);
                DB.closeConnection();
            }
            else
                MessageBox.Show("Could not establish connection with the database.", "Error");
        }

        public String getUserIdFromEmail(String email)
        {
            String userEmail = "";
            
            DB.openConnection();
            if (DB.isConnOpen())
            {
                DBQ.retrieveUserIdFromEmail(email);
                DB.closeConnection();
            }
            else
                MessageBox.Show("Could not establish connection with the database.", "Error");

            return userEmail;
        }

        public String getUserEmailFromId(String userId)
        {
            String userEmail = "";

            DB.openConnection();
            if (DB.isConnOpen())
            {
                DBQ.retrieveUserEmailFromId(userId);
                DB.closeConnection();
            }
            else
                MessageBox.Show("Could not establish connection with the database.", "Error");

            return userEmail;
        }

        public void changeCollaborator(Playlist playlist, String userId)
        {
            DB.openConnection();
            if (DB.isConnOpen())
            {
                DBQ.updateCollaborator(playlist, userId);
                DB.closeConnection();
            }
            else
                MessageBox.Show("Could not establish connection with the database.", "Error");
        }

        public void deletePlaylist(Playlist playlist)
        {
            DB.openConnection();
            if (DB.isConnOpen())
            {
                DBQ.removePlaylistFromDB(playlist);
                DB.closeConnection();
            }
            else
                MessageBox.Show("Could not establish connection with the database.", "Error");
        }
    }
}
