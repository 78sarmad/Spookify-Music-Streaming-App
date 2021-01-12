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
    public partial class CollaboratorForm : Form
    {
        Operations DBO;
        private Playlist Playlist;

        public CollaboratorForm(Playlist Playlist)
        {
            InitializeComponent();
            DBO = new Operations();
            this.Playlist = Playlist;
        }

        private void CollaboratorForm_Load(object sender, EventArgs e)
        {
            CurrentCollabTbx.Text = DBO.getUserEmailFromId(Playlist.Collaborator);
        }

        private void ChangeCollabBtn_Click(object sender, EventArgs e)
        {
            String NewCollabEmail = DBO.getUserIdFromEmail(NewCollabInput.Text);

            if (NewCollabEmail.Length > 0)
            {
                DBO.changeCollaborator(Playlist, NewCollabEmail);
                DBO.loadUserData();
                MessageBox.Show("Playlist Collaborater updated.", "Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("User not found. Please recheck email.", "Error");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CollaboratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ViewPlaylistScreen VPS = new ViewPlaylistScreen(Playlist);
            VPS.Show();
        }
    }
}
