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
    public partial class CreatePlaylistForm : Form
    {
        Operations DBO;

        public CreatePlaylistForm()
        {
            InitializeComponent();
            DBO = new Operations();
        }

        private void CreatePlaylistBtn_Click(object sender, EventArgs e)
        {
            DBO.createPlaylist(PlaylistNameInput.Text);
            DBO.loadUserData();
            MessageBox.Show("Playlist created.", "Success");
            this.Dispose();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
