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
    public partial class PlaylistsScreen : Form
    {
        WebClient WC;
        Operations DBO;

        private List<Track> new_tracks;
        private Playlist playlist1, playlist2, playlist3;
        private Media_Functions MEF;

        public PlaylistsScreen()
        {
            InitializeComponent();
            WC = new WebClient();
            DBO = new Operations();

            new_tracks = new List<Track>();
            MEF = new Media_Functions();
        }

        private void PlaylistsScreen_Load(object sender, EventArgs e)
        {
            SignedInTitle.Text = Session.ActiveUser.Name;
            if (Session.isTrackLoaded)
                loadTrackInfo();
            setNowPlaying();

            int playlistCount = Session.ActiveUser.Playlists.Count;

            if (playlistCount > 0)
            {
                playlist1 = Session.ActiveUser.Playlists.ElementAt(0);
                Playlist1Cover.BackgroundImage = new Bitmap(VP_Project.Properties.Resources.playlist_96px);
                Playlist1Name.Text = playlist1.Name;
                Playlist1Tracks.Text = playlist1.NoOfTracks + " Tracks";

                if (playlistCount > 1)
                {
                    playlist2 = Session.ActiveUser.Playlists.ElementAt(1);
                    Playlist2Cover.BackgroundImage = new Bitmap(VP_Project.Properties.Resources.playlist_96px);
                    Playlist2Name.Text = playlist2.Name;
                    Playlist2Tracks.Text = playlist2.NoOfTracks + " Tracks";

                    if (playlistCount > 2)
                    {
                        playlist3 = Session.ActiveUser.Playlists.ElementAt(2);
                        Playlist3Cover.BackgroundImage = new Bitmap(VP_Project.Properties.Resources.playlist_96px);
                        Playlist3Name.Text = playlist3.Name;
                        Playlist3Tracks.Text = playlist3.NoOfTracks + " Tracks";
                    }
                }
            }
        }

        private void Playlist1Cover_Click(object sender, EventArgs e)
        {
            ViewPlaylistScreen VPS = new ViewPlaylistScreen(playlist1);
            VPS.Show();
            this.Close();
        }

        private void Playlist1Name_Click(object sender, EventArgs e)
        {
            ViewPlaylistScreen VPS = new ViewPlaylistScreen(playlist1);
            VPS.Show();
            this.Close();
        }

        private void Playlist2Cover_Click(object sender, EventArgs e)
        {
            ViewPlaylistScreen VPS = new ViewPlaylistScreen(playlist2);
            VPS.Show();
            this.Close();
        }

        private void Playlist2Name_Click(object sender, EventArgs e)
        {
            ViewPlaylistScreen VPS = new ViewPlaylistScreen(playlist2);
            VPS.Show();
            this.Close();
        }

        private void Playlist3Cover_Click(object sender, EventArgs e)
        {
            ViewPlaylistScreen VPS = new ViewPlaylistScreen(playlist3);
            VPS.Show();
            this.Close();
        }

        private void Playlist3Name_Click(object sender, EventArgs e)
        {
            ViewPlaylistScreen VPS = new ViewPlaylistScreen(playlist3);
            VPS.Show();
            this.Close();
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

        private void DiscoverBtn_Click(object sender, EventArgs e)
        {
            HomeScreen HS = new HomeScreen();
            HS.Show();
            this.Close();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreatePlaylistForm CPF = new CreatePlaylistForm();
            CPF.Show();
            this.Close();
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
