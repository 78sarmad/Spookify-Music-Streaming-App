using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Project.Models
{
    public class Queue
    {
        private List<Track> queued_tracks;

        public Queue()
        {
            queued_tracks = new List<Track>();
        }

        public List<Track> QueuedTracks
        {
            get
            {
                return queued_tracks;
            }
            set
            {
                queued_tracks = value;
            }
        }
    }
}
