namespace VP_Project.Views.Mini_Forms
{
    partial class ViewMoreTracksForm
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
            this.Track1Name = new System.Windows.Forms.Label();
            this.TracksLbx = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.PlayTrackBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Track1Name
            // 
            this.Track1Name.AutoSize = true;
            this.Track1Name.Font = new System.Drawing.Font("Montserrat SemiBold", 10F);
            this.Track1Name.Location = new System.Drawing.Point(13, 20);
            this.Track1Name.Name = "Track1Name";
            this.Track1Name.Size = new System.Drawing.Size(135, 24);
            this.Track1Name.TabIndex = 52;
            this.Track1Name.Text = "Playlist Tracks";
            // 
            // TracksLbx
            // 
            this.TracksLbx.FormattingEnabled = true;
            this.TracksLbx.ItemHeight = 16;
            this.TracksLbx.Location = new System.Drawing.Point(13, 58);
            this.TracksLbx.Name = "TracksLbx";
            this.TracksLbx.Size = new System.Drawing.Size(258, 148);
            this.TracksLbx.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 250);
            this.panel1.TabIndex = 54;
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
            // PlayTrackBtn
            // 
            this.PlayTrackBtn.BackColor = System.Drawing.Color.Navy;
            this.PlayTrackBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.PlayTrackBtn.ForeColor = System.Drawing.Color.White;
            this.PlayTrackBtn.Location = new System.Drawing.Point(191, 218);
            this.PlayTrackBtn.Name = "PlayTrackBtn";
            this.PlayTrackBtn.Size = new System.Drawing.Size(80, 28);
            this.PlayTrackBtn.TabIndex = 53;
            this.PlayTrackBtn.Text = "PLAY";
            this.PlayTrackBtn.UseVisualStyleBackColor = false;
            this.PlayTrackBtn.Click += new System.EventHandler(this.PlayTrackBtn_Click);
            // 
            // ViewMoreTracksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.Track1Name);
            this.Controls.Add(this.TracksLbx);
            this.Controls.Add(this.PlayTrackBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMoreTracksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMoreTracksForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewMoreTracksForm_FormClosed);
            this.Load += new System.EventHandler(this.ViewMoreTracksForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Track1Name;
        private System.Windows.Forms.ListBox TracksLbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Button PlayTrackBtn;
    }
}