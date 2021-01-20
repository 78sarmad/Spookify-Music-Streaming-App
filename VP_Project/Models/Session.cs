using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project.Models
{
    public class Session
    {
        // singleton error provider - accessed from anywhere
        public static ErrorProvider ErrProv = new ErrorProvider();

        // stores info on user that is signed in
        public static User ActiveUser = new User();
        
        // keeps an active sound player throughout the program's lifetime
        public static SoundPlayer Player = new SoundPlayer();
        public static Track NowPlaying = new Track();
        public static bool isTrackLoaded = false;
        public static bool isPlaying = false;

        public static List<Track> TracksInQueue = new List<Track>();
        public static int trackIndex = 0;
    }
}
