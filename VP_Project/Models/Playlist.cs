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
        public List<String> collaborators;
        public List<Track> tracks;

        public Playlist()
        {
            collaborators = new List<String>();
        }

        public List<String> Collaborators
        {
            get
            {
                return collaborators;
            }
            set
            {
                collaborators = value;
            }
        }
    }
}
