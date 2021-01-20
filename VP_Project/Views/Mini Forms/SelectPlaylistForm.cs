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
        }

        private void SelectPlaylistForm_Load(object sender, EventArgs e)
        {
            my_playlists = DBO.getPlaylists();

            foreach (Playlist playlist in my_playlists)
                PlaylistsLbx.Items.Add(playlist.Name + "\t" + playlist.NoOfTracks + " Tracks");
        }

        private void AddTrackToPlaylistBtn_Click(object sender, EventArgs e)
        {
            if (PlaylistsLbx.SelectedIndex != -1)
            {
                Playlist selected_playlist = my_playlists.ElementAt(PlaylistsLbx.SelectedIndex);
                Track selected_track = Session.NowPlaying;
                DBO.addTrackToPlaylist(selected_playlist, selected_track);
                DBO.loadUserData();

                MessageBox.Show("Track added to playlist.", "Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("No playlists selected. \nIf you do not see any playlists here, \nyou may want to create them from Playlists page.", "Error");
                this.Close();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
