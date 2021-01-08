using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Project.Models
{
    public class User
    {
        public String UserID { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }

        private List<Playlist> playlists;
        private List<Track> liked_tracks;

        public User()
        {
            playlists = new List<Playlist>();
            liked_tracks = new List<Track>();
        }

        public List<Playlist> Playlists
        {
            get
            {
                return playlists;
            }
            set
            {
                playlists = value;
            }
        }

        public List<Track> Liked_Tracks
        {
            get
            {
                return liked_tracks;
            }
            set
            {
                liked_tracks = value;
            }
        }
    }
}
