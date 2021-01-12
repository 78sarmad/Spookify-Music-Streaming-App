using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Project.Models;

namespace VP_Project.Controllers
{
    public class Media_Functions
    {
        public void loadMusic()
        {
            Session.Player.Stop();
            Session.Player.LoadTimeout = 300000;
            Session.Player.SoundLocation = Session.NowPlaying.URL;
            Session.Player.LoadAsync();
            playMusic();
        }

        public void playMusic()
        {
            if (Session.isTrackLoaded)
            {
                Session.Player = new System.Media.SoundPlayer();
                Session.Player.LoadTimeout = 300000;
                Session.Player.SoundLocation = Session.NowPlaying.URL;
                Session.Player.LoadAsync();
            }
                
            Session.Player.Play();
            Session.isPlaying = true;
        }

        public void stopMusic()
        {
            Session.Player.Stop();
            Session.isPlaying = false;
        }
    }
}
