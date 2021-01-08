using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Project.Models
{
    public class Queue
    {
        private List<Track> tracks_in_queue;

        public Queue()
        {
            tracks_in_queue = new List<Track>();
        }

        public List<Track> Tracks_In_Queue
        {
            get
            {
                return tracks_in_queue;
            }
            set
            {
                tracks_in_queue = value;
            }
        }
    }
}
