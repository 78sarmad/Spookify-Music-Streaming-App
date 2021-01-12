using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Project.Controllers;
using VP_Project.Models;

namespace VP_Project.Views.Mini_Forms
{
    public partial class DeletePlaylistForm : Form
    {
        private Operations DBO;
        private Playlist Playlist;

        public DeletePlaylistForm(Playlist Playlist)
        {
            InitializeComponent();
            DBO = new Operations();
            this.Playlist = Playlist;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DBO.deletePlaylist(Playlist);
            DBO.loadUserData();
            MessageBox.Show("Playlist has been deleted.", "Success");

            PlaylistsScreen PS = new PlaylistsScreen();
            PS.Show();
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ViewPlaylistScreen VPS = new ViewPlaylistScreen(Playlist);
            VPS.Show();
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            ViewPlaylistScreen VPS = new ViewPlaylistScreen(Playlist);
            VPS.Show();
            this.Close();
        }
    }
}
