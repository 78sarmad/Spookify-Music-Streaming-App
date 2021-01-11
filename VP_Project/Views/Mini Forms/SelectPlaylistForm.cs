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
    public partial class SelectPlaylistForm : Form
    {
        Operations DBO;
        List<Playlist> my_playlists;

        public SelectPlaylistForm()
        {
            InitializeComponent();
            DBO = new Operations();
            my_playlists = DBO.getPlaylists();
        }

        private void SelectPlaylistForm_Load(object sender, EventArgs e)
        {
            foreach (Playlist playlist in my_playlists)
                PlaylistsLbx.Items.Add(playlist.Name);
        }

        private void AddTrackBtn_Click(object sender, EventArgs e)
        {
            Playlist selected_playlist = my_playlists.ElementAt(PlaylistsLbx.SelectedIndex);
            Track selected_track = Session.NowPlaying;
            DBO.addTrackToPlaylist(selected_playlist, selected_track);

            MessageBox.Show("Track added to playlist.", "Success");
            this.Dispose();
        }
    }
}
