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
        public static ErrorProvider ErrProv = new ErrorProvider();
        public static String ActiveUserID;
        public static String ActiveUserName;
        public static SoundPlayer Player = new SoundPlayer();
        public static Track NowPlaying = new Track();
        public static bool isPlaying = false;
    }
}
