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
            this.AddTrackBtn.BackColor = System.Drawing.Color.Navy;
            this.AddTrackBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.AddTrackBtn.ForeColor = System.Drawing.Color.White;
            this.AddTrackBtn.Location = new System.Drawing.Point(190, 213);
            this.AddTrackBtn.Name = "AddTrackBtn";
            this.AddTrackBtn.Size = new System.Drawing.Size(80, 28);
            this.AddTrackBtn.TabIndex = 47;
            this.AddTrackBtn.Text = "ADD";
            this.AddTrackBtn.UseVisualStyleBackColor = false;
            this.AddTrackBtn.Click += new System.EventHandler(this.AddTrackBtn_Click);
            // 
            // SelectPlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.AddTrackBtn);
            this.Controls.Add(this.Track1Name);
            this.Controls.Add(this.PlaylistsLbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectPlaylistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectPlaylistForm";
            this.Load += new System.EventHandler(this.SelectPlaylistForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PlaylistsLbx;
        private System.Windows.Forms.Label Track1Name;
        private System.Windows.Forms.Button AddTrackBtn;
    }
}