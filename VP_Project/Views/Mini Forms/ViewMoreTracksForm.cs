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
    public partial class ViewMoreTracksForm : Form
    {
        private Operations DBO;
        private Playlist Playlist;
        private bool isPlayPressed;

        public ViewMoreTracksForm(Playlist Playlist)
        {
            InitializeComponent();
            DBO = new Operations();
            this.Playlist = Playlist;
            isPlayPressed = false;
        }

        private void ViewMoreTracksForm_Load(object sender, EventArgs e)
        {
            foreach (Track Track in Playlist.Tracks)
                TracksLbx.Items.Add(Track.Name + "\t" + Track.Artist + "\t" + Track.Duration);
        }

        private void PlayTrackBtn_Click(object sender, EventArgs e)
        {
            isPlayPressed = true;
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewMoreTracksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Track SelectedTrack;
            if (isPlayPressed)
            {
                SelectedTrack = Playlist.Tracks.ElementAt(TracksLbx.SelectedIndex);
                Session.isTrackLoaded = true;
            }
            else
                SelectedTrack = Session.NowPlaying;
        }
    }
}
