using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VP_Project.Models;

namespace VP_Project.Controllers
{
    public class Operations
    {
        DB_Queries DBQ;

        public Operations()
        {
            DBQ = new DB_Queries();
        }

        public bool trySignIn(String email, String password)
        {
            bool success = false;
            User user = DBQ.findUser(email, password);

            if (email == user.Email)
            {
                Session.ActiveUser.UserID = user.UserID;
                Session.ActiveUser.Name = user.Name;
                Session.ActiveUser.Email = user.Email;
                success = true;
            }

            return success;
        }

        public bool signUp(String name, String email, String password)
        {
            bool success = false;
            DBQ.addUser(name, email, password);

            User user = DBQ.findUser(email, password);
            if (email == user.Email)
                success = true;

            return success;
        }

        public void signOut()
        {
            Session.ActiveUser = null;
            Session.NowPlaying = null;
            Session.ErrProv.Clear();
        }

        public void loadUserData()
        {
            Session.ActiveUser = DBQ.loadUserDataFromDB(Session.ActiveUser.UserID);
        }

        public List<Track> loadNewTracks()
        {
            List<Track> new_tracks = DBQ.queryNewTracks();
            return new_tracks;
        }

        public List<Playlist> getPlaylists()
        {
            List<Playlist> my_playlists = DBQ.retrievePlaylists(Session.ActiveUser.UserID);
            return my_playlists;
        }

        public void addTrackToPlaylist(Playlist playlist, Track track)
        {
            DBQ.insertTrackInPlaylist(playlist, track);
        }

        public void createPlaylist(String playlistName)
        {
            DBQ.createNewPlaylist(playlistName, Session.ActiveUser.UserID);
        }

        public String getUserIdFromEmail(String email)
        {
            String userEmail = DBQ.retrieveUserIdFromEmail(email);
            return userEmail;
        }

        public String getUserEmailFromId(String userId)
        {
            String userEmail = DBQ.retrieveUserEmailFromId(userId);
            return userEmail;
        }

        public void changeCollaborator(Playlist playlist, String userId)
        {
            DBQ.updateCollaborator(playlist, userId);
        }

        public void deletePlaylist(Playlist playlist)
        {
            DBQ.removePlaylistFromDB(playlist);
        }
    }
}
