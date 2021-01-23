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
    public partial class SearchTrackForm : Form
    {
        private Operations DBO;
        private Media_Functions MEF;
        private String findTerm;
        private List<Track> searchResults;
        private bool isPlayPressed = false;

        public SearchTrackForm(String searchTerm)
        {
            InitializeComponent();
            DBO = new Operations();
            MEF = new Media_Functions();
            findTerm = searchTerm;
        }

        private void SearchTrackForm_Load(object sender, EventArgs e)
        {
            searchResults = DBO.searchTrack(findTerm);

            foreach (Track track in searchResults)
                TrackResultsLbx.Items.Add(track.Name + "\t" + track.Artist);
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            isPlayPressed = true;
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchOnlineBtn_Click(object sender, EventArgs e)
        {
            String searchURL = "https://www.youtube.com/results?search_query=" + findTerm;
            System.Diagnostics.Process.Start(searchURL);
        }

        private void SearchTrackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Track SelectedTrack;
            if (isPlayPressed)
            {
                SelectedTrack = searchResults.ElementAt(TrackResultsLbx.SelectedIndex);
                Session.isTrackLoaded = true;
            }            
            else
                SelectedTrack = Session.NowPlaying;

            MEF.loadMusic();
            HomeScreen HS = new HomeScreen();
            HS.Show();
        }
    }
}
