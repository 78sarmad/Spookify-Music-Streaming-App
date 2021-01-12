namespace VP_Project.Views.Mini_Forms
{
    partial class SelectPlaylistForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlaylistsLbx = new System.Windows.Forms.ListBox();
            this.Track1Name = new System.Windows.Forms.Label();
            this.AddTrackBtn = new System.Windows.Forms.Button();
            this.AddTrackToPlaylistBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlaylistsLbx
            // 
            this.PlaylistsLbx.FormattingEnabled = true;
            this.PlaylistsLbx.ItemHeight = 16;
            this.PlaylistsLbx.Location = new System.Drawing.Point(12, 59);
            this.PlaylistsLbx.Name = "PlaylistsLbx";
            this.PlaylistsLbx.Size = new System.Drawing.Size(258, 148);
            this.PlaylistsLbx.TabIndex = 45;
            // 
            // Track1Name
            // 
            this.Track1Name.AutoSize = true;
            this.Track1Name.Font = new System.Drawing.Font("Montserrat SemiBold", 10F);
            this.Track1Name.Location = new System.Drawing.Point(12, 21);
            this.Track1Name.Name = "Track1Name";
            this.Track1Name.Size = new System.Drawing.Size(191, 24);
            this.Track1Name.TabIndex = 46;
            this.Track1Name.Text = "Add Track to Playlist";
            // 
            // AddTrackBtn
            // 
            this.AddTrackBtn.Location = new System.Drawing.Point(0, 0);
            this.AddTrackBtn.Name = "AddTrackBtn";
            this.AddTrackBtn.Size = new System.Drawing.Size(75, 23);
            this.AddTrackBtn.TabIndex = 0;
            // 
            // AddTrackToPlaylistBtn
            // 
            this.AddTrackToPlaylistBtn.BackColor = System.Drawing.Color.Navy;
            this.AddTrackToPlaylistBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.AddTrackToPlaylistBtn.ForeColor = System.Drawing.Color.White;
            this.AddTrackToPlaylistBtn.Location = new System.Drawing.Point(190, 219);
            this.AddTrackToPlaylistBtn.Name = "AddTrackToPlaylistBtn";
            this.AddTrackToPlaylistBtn.Size = new System.Drawing.Size(80, 28);
            this.AddTrackToPlaylistBtn.TabIndex = 48;
            this.AddTrackToPlaylistBtn.Text = "ADD";
            this.AddTrackToPlaylistBtn.UseVisualStyleBackColor = false;
            this.AddTrackToPlaylistBtn.Click += new System.EventHandler(this.AddTrackToPlaylistBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 254);
            this.panel1.TabIndex = 49;
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Red;
            this.ExitBtn.Location = new System.Drawing.Point(248, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(22, 24);
            this.ExitBtn.TabIndex = 50;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SelectPlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 259);
            this.Controls.Add(this.AddTrackToPlaylistBtn);
            this.Controls.Add(this.Track1Name);
            this.Controls.Add(this.PlaylistsLbx);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectPlaylistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectPlaylistForm";
            this.Load += new System.EventHandler(this.SelectPlaylistForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PlaylistsLbx;
        private System.Windows.Forms.Label Track1Name;
        private System.Windows.Forms.Button AddTrackBtn;
        private System.Windows.Forms.Button AddTrackToPlaylistBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExitBtn;
    }
}