using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            HomeScreen HS = new HomeScreen();
            HS.Show();

            PlaylistsScreen PS = new PlaylistsScreen();
            PS.Show();

            ViewPlaylistScreen VPS = new ViewPlaylistScreen();
            VPS.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
