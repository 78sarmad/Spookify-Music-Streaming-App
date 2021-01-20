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
            if (TrackResultsLbx.SelectedIndex != -1)
            {
                Track selected_track = searchResults.ElementAt(TrackResultsLbx.SelectedIndex);
                Session.NowPlaying = selected_track;
                Session.isTrackLoaded = true;

                HomeScreen HS = new HomeScreen();
                HS.Show();
                this.Close();
                MEF.loadMusic();
            }
            else
            {
                MessageBox.Show("No track selected.", "Error");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            HomeScreen HS = new HomeScreen();
            HS.Show();
            this.Close();
        }

        private void SearchOnlineBtn_Click(object sender, EventArgs e)
        {
            String searchURL = "https://www.youtube.com/results?search_query=" + findTerm;
            System.Diagnostics.Process.Start(searchURL);
        }
    }
}
