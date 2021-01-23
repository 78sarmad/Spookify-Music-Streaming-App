using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Project.Controllers;
using VP_Project.Models;
using VP_Project.Views.Mini_Forms;

namespace VP_Project
{
    public partial class HomeScreen : Form
    {
        WebClient WC;
        Operations DBO;

        private List<Track> new_tracks;
        private Track track1, track2, track3;
        private Media_Functions MEF;

        public HomeScreen()
        {
            InitializeComponent();
            WC = new WebClient();
            DBO = new Operations();
            DBO.loadUserData();

            new_tracks = DBO.loadNewTracks();
            MEF = new Media_Functions();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            SignedInTitle.Text = Session.ActiveUser.Name;
            if (Session.isTrackLoaded)
                loadTrackInfo();
            setNowPlaying();

            if (new_tracks.Count > 0)
            {
                track1 = new_tracks.ElementAt(0);

                Track1Cover.BackgroundImage = Image.FromStream(WC.OpenRead(track1.Cover_URL));
                Track1Name.Text = track1.Name;
                Track1Artist.Text = track1.Artist;
                Track1Duration.Text = track1.Duration;

                if (new_tracks.Count > 1)
                {
                    track2 = new_tracks.ElementAt(1);

                    Track2Cover.BackgroundImage = Image.FromStream(WC.OpenRead(track2.Cover_URL));
                    Track2Name.Text = track2.Name;
                    Track2Artist.Text = track2.Artist;
                    Track2Duration.Text = track2.Duration;

                    if (new_tracks.Count > 2)
                    {
                        track3 = new_tracks.ElementAt(2);

                        Track3Cover.BackgroundImage = Image.FromStream(WC.OpenRead(track3.Cover_URL));
                        Track3Name.Text = track3.Name;
                        Track3Artist.Text = track3.Artist;
                        Track3Duration.Text = track3.Duration;
                    }
                }
            }
        }

        private void Track1Cover_Click(object sender, EventArgs e)
        {
            Session.NowPlaying = track1;
            setSyncLabel();
            MEF.loadMusic();
            setNowPlaying();
        }

        private void Track1Name_Click(object sender, EventArgs e)
        {
            Session.NowPlaying = track1;
            setSyncLabel();
            MEF.loadMusic();
            setNowPlaying();
        }

        private void Track2Cover_Click(object sender, EventArgs e)
        {
            Session.NowPlaying = track2;
            setNowPlaying();
            setSyncLabel();
            MEF.loadMusic();
            setNowPlaying();
        }

        private void Track2Name_Click(object sender, EventArgs e)
        {
            Session.NowPlaying = track2;
            setNowPlaying();
            setSyncLabel();
            MEF.loadMusic();
            setNowPlaying();
        }

        private void Track3Cover_Click(object sender, EventArgs e)
        {
            Session.NowPlaying = track3;
            setSyncLabel();
            MEF.loadMusic();
            setNowPlaying();
        }

        private void Track3Name_Click(object sender, EventArgs e)
        {
            Session.NowPlaying = track3;
            setSyncLabel();
            MEF.loadMusic();
            setNowPlaying();
        }

        private void loadTrackInfo()
        {
            NowPlayingName.Text = Session.NowPlaying.Name;
            NowPlayingArtist.Text = Session.NowPlaying.Artist;
            if (Session.NowPlaying.Cover_URL != null)
                NowPlayingCover.BackgroundImage = Image.FromStream(WC.OpenRead(Session.NowPlaying.Cover_URL));
            NowPlayingCover.BorderStyle = BorderStyle.None;
        }

        private void setSyncLabel()
        {
            loadTrackInfo();
            Session.isTrackLoaded = true;
            StatusLbl.Text = "SYNCING TRACK...";
        }

        private void setNowPlaying()
        {
            if (Session.isPlaying)
            {
                StatusLbl.Text = "NOW PLAYING";
                PlayStopBtn.BackgroundImage = new Bitmap(VP_Project.Properties.Resources.stop_100px);
            }
            else
            {
                PlayStopBtn.BackgroundImage = new Bitmap(VP_Project.Properties.Resources.play_blue);
            }
        }

        private void PlayStopBtn_Click(object sender, EventArgs e)
        {
            if (Session.isTrackLoaded)
            {
                if (Session.isPlaying)
                    MEF.stopMusic();
                else
                    MEF.playMusic();

                setNowPlaying();
            }
        }

        private void ShareBtn_Click(object sender, EventArgs e)
        {
            if (Session.isTrackLoaded)
            {
                ShareTrackForm STF = new ShareTrackForm();
                STF.Show();
            }
        }

        private void PlaylistsBtn_Click(object sender, EventArgs e)
        {
            PlaylistsScreen PLS = new PlaylistsScreen();
            PLS.Show();
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (Session.isTrackLoaded)
            {
                SelectPlaylistForm SPF = new SelectPlaylistForm();
                SPF.Show();
            }
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBO.signOut();

            SignInScreen SIS = new SignInScreen();
            SIS.Show();
            this.Close();
        }

        private void SignedInTitle_Click(object sender, EventArgs e)
        {
            UserMenu.Show(Cursor.Position);
        }

        private void UserIcon_Click(object sender, EventArgs e)
        {
            UserMenu.Show(Cursor.Position);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            setSyncLabel();
            MEF.loadPrev();
            setNowPlaying();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            setSyncLabel();
            MEF.loadNext();
            setNowPlaying();
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            ToolTip HelpTip = new ToolTip();
            HelpTip.ShowAlways = true;
            HelpTip.SetToolTip(panel2, "Play a track to use player functionality.");  
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (TrackSearchTbx.Text != "")
            {
                SearchTrackForm STF = new SearchTrackForm(TrackSearchTbx.Text);
                STF.Show();
                this.Close();
            }
        }
    }
}
