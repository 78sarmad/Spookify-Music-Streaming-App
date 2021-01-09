using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Project.Models;

namespace VP_Project
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            Database.openConnection();
            if (Database.isConnValid())
                MessageBox.Show("Yep");


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
