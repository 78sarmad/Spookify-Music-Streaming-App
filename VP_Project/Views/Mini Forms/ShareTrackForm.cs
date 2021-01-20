using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Project.Models;

namespace VP_Project.Views.Mini_Forms
{
    public partial class ShareTrackForm : Form
    {
        public ShareTrackForm()
        {
            InitializeComponent();
        }

        private void ShareTrackForm_Load(object sender, EventArgs e)
        {
            TrackNameLbl.Text += Session.NowPlaying.Name;
            TrackArtistLbl.Text += Session.NowPlaying.Artist;
            TrackLinkTbx.Text = Session.NowPlaying.URL;
        }

        private void ShareBtn_Click(object sender, EventArgs e)
        {
            if (TrackEmailTbx.Text == "" || !TrackEmailTbx.Text.Contains("@") || !TrackEmailTbx.Text.Contains("."))
            {
                Session.ErrProv.SetError(TrackEmailTbx, "Specify a valid email");
            }
            else
            {
                string mailto = string.Format("mailto:{0}?Subject={1}&Body={2}", TrackEmailTbx.Text, "Track Shared via Spookify", "Stream Link: " + Session.NowPlaying.URL);
                System.Diagnostics.Process.Start(mailto);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
