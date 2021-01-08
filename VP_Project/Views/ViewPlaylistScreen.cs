using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class ViewPlaylistScreen : Form
    {
        SoundPlayer Player;

        public ViewPlaylistScreen()
        {
            InitializeComponent();

            Player = new SoundPlayer();
            Player.LoadTimeout = 60000;
            Player.SoundLocation = "https://www2.cs.uic.edu/~i101/SoundFiles/CantinaBand3.wav";
            Player.Play();
        }
    }
}
