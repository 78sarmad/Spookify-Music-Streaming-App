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
    public partial class ViewPlaylistScreen : Form
    {
        WebClient WC;
        Operations DBO;

        private Media_Functions MEF;
        private Playlist Playlist;
        private Track Track1, Track2, Track3;

        public ViewPlaylistScreen(Playlist Playlist)
        {
            InitializeComponent();
            WC = new WebClient();
            DBO = new Operations();

            this.Playlist = Playlist;
            MEF = new Media_Functions();
        }

        private void ViewPlaylistScreen_Load(object sender, EventArgs e)
        {
            DBO.loadUserData();

            SignedInTitle.Text = Session.ActiveUser.Name;
            PlaylistNameLbl.Text = Playlist.Name;
            if (Session.isTrackLoaded)
                loadTrackInfo();
            setNowPlaying();

            if (Playlist.Tracks.Count > 0)
            {
                Track1 = Playlist.Tracks.ElementAt(0);

                Track1Cover.BackgroundImage = Image.FromStream(WC.OpenRead(Track1.Cover_URL));
                Track1Name.Text = Track1.Name;
                Track1Artist.Text = Track1.Artist;
                Track1Duration.Text = Track1.Duration;

                if (Playlist.Tracks.Count > 1)
                {
                    Track2 = Playlist.Tracks.ElementAt(1);

                    Track2Cover.BackgroundImage = Image.FromStream(WC.OpenRead(Track2.Cover_URL));
                    Track2Name.Text = Track2.Name;
                    Track2Artist.Text = Track2.Artist;
                    Track2Duration.Text = Track2.Duration;

                    if (Playlist.Tracks.Count > 2)
                    {
                        Track3 = Playlist.Tracks.ElementAt(2);

                        Track3Cover.BackgroundImage = Image.FromStream(WC.OpenRead(Track3.Cover_URL));
                        Track3Name.Text = Track3.Name;
                        Track3Artist.Text = Track3.Artist;
                        Track3Duration.Text = Track3.Duration;

                        if (Playlist.Tracks.Count > 3)
                            ViewMoreLbl.Visible = true;
                    }
                }
            }
        }

        private void ViewMoreLbl_Click(object sender, EventArgs e)
        {
            ViewMoreTracksForm VMTF = new ViewMoreTracksForm(Playlist);
            VMTF.Show();

            setSyncLabel();
            MEF.loadMusic();
            setNowPlaying();
        }

        private void Track1Cover_Click(object sender, EventArgs e)
        {
            Session.NowPlaying = Track1;
            setSyncLabel();
            MEF.loadMusic();
            setNowPlaying();
        }

        private void Track1Name_Click(object sender, EventArgs e)
        {
            Session.NowPlaying = Track1;
            setSyncLabel();
            MEF.loadMusic();
            setNowPlaying();
        }

        private void Track2Cover_Click(object sender, EventArgs e)
        {
            Session.NowPlaying = Track2;
            setNowPlaying();
            setSyncLabel();
            MEF.loadMusic();
            setNowPlaying();
        }

        private void Track2Name_Click(object sender, EventArgs e)
        {
            Session.NowPlaying = Track2;
            setNowPlaying();
            setSyncLabel();
            MEF.loadMusic();
            setNowPlaying();
        }

        private void Track3Cover_Click(object sender, EventArgs e)
        {
            Session.NowPlaying = Track3;
            setSyncLabel();
            MEF.loadMusic();
            setNowPlaying();
        }

        private void Track3Name_Click(object sender, EventArgs e)
        {
            Session.NowPlaying = Track3;
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

        private void DiscoverBtn_Click(object sender, EventArgs e)
        {
            HomeScreen HS = new HomeScreen();
            HS.Show();
            this.Close();
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

        private void CollaboratorsBtn_Click(object sender, EventArgs e)
        {
            CollaboratorForm CF = new CollaboratorForm(Playlist);
            CF.Show();
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeletePlaylistForm DPF = new DeletePlaylistForm(Playlist);
            DPF.Show();
            this.Close();
        }

        private void PlayPlaylistBtn_Click(object sender, EventArgs e)
        {
            foreach (Track track in Playlist.Tracks)
                Session.TracksInQueue.Add(track);

            Session.trackIndex = 0;
            Session.NowPlaying = Session.TracksInQueue.ElementAt(Session.trackIndex);

            setSyncLabel();
            MEF.loadMusic();
            setNowPlaying();
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
    }
}
