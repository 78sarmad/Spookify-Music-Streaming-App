using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Project.Models
{
    public class Playlist
    {
        public String PlaylistID { get; set; }
        public String Name { get; set; }
        public String NoOfTracks { get; set; }
        public String Collaborator { get; set; }
        public List<Track> tracks;

        public Playlist()
        {
            tracks = new List<Track>();
        }

        public List<Track> Tracks
        {
            get
            {
                return tracks;
            }
            set
            {
                tracks = value;
            }
        }
    }
}
