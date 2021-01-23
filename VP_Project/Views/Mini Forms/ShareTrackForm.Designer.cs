namespace VP_Project.Views.Mini_Forms
{
    partial class ShareTrackForm
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
            this.TrackEmailTbx = new System.Windows.Forms.TextBox();
            this.ShareBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TrackArtistLbl = new System.Windows.Forms.Label();
            this.TrackNameLbl = new System.Windows.Forms.Label();
            this.TrackLinkTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Track1Name
            // 
            this.Track1Name.AutoSize = true;
            this.Track1Name.Font = new System.Drawing.Font("Montserrat SemiBold", 10F);
            this.Track1Name.Location = new System.Drawing.Point(12, 21);
            this.Track1Name.Name = "Track1Name";
            this.Track1Name.Size = new System.Drawing.Size(114, 24);
            this.Track1Name.TabIndex = 49;
            this.Track1Name.Text = "Share Track";
            // 
            // TrackEmailTbx
            // 
            this.TrackEmailTbx.Location = new System.Drawing.Point(12, 194);
            this.TrackEmailTbx.Name = "TrackEmailTbx";
            this.TrackEmailTbx.Size = new System.Drawing.Size(237, 22);
            this.TrackEmailTbx.TabIndex = 0;
            // 
            // ShareBtn
            // 
            this.ShareBtn.BackColor = System.Drawing.Color.Navy;
            this.ShareBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.ShareBtn.ForeColor = System.Drawing.Color.White;
            this.ShareBtn.Location = new System.Drawing.Point(263, 191);
            this.ShareBtn.Name = "ShareBtn";
            this.ShareBtn.Size = new System.Drawing.Size(97, 28);
            this.ShareBtn.TabIndex = 47;
            this.ShareBtn.Text = "SHARE";
            this.ShareBtn.UseVisualStyleBackColor = false;
            this.ShareBtn.Click += new System.EventHandler(this.ShareBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TrackArtistLbl);
            this.panel1.Controls.Add(this.TrackNameLbl);
            this.panel1.Controls.Add(this.TrackLinkTbx);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TrackEmailTbx);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.ShareBtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 236);
            this.panel1.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 8F);
            this.label4.Location = new System.Drawing.Point(8, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Share via Email:";
            // 
            // TrackArtistLbl
            // 
            this.TrackArtistLbl.AutoSize = true;
            this.TrackArtistLbl.Font = new System.Drawing.Font("Montserrat SemiBold", 8F);
            this.TrackArtistLbl.Location = new System.Drawing.Point(8, 85);
            this.TrackArtistLbl.Name = "TrackArtistLbl";
            this.TrackArtistLbl.Size = new System.Drawing.Size(59, 20);
            this.TrackArtistLbl.TabIndex = 52;
            this.TrackArtistLbl.Text = "Artist:  ";
            // 
            // TrackNameLbl
            // 
            this.TrackNameLbl.AutoSize = true;
            this.TrackNameLbl.Font = new System.Drawing.Font("Montserrat SemiBold", 8F);
            this.TrackNameLbl.Location = new System.Drawing.Point(8, 55);
            this.TrackNameLbl.Name = "TrackNameLbl";
            this.TrackNameLbl.Size = new System.Drawing.Size(68, 20);
            this.TrackNameLbl.TabIndex = 51;
            this.TrackNameLbl.Text = "Name:   ";
            // 
            // TrackLinkTbx
            // 
            this.TrackLinkTbx.HideSelection = false;
            this.TrackLinkTbx.Location = new System.Drawing.Point(117, 116);
            this.TrackLinkTbx.Name = "TrackLinkTbx";
            this.TrackLinkTbx.Size = new System.Drawing.Size(243, 22);
            this.TrackLinkTbx.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 8F);
            this.label1.Location = new System.Drawing.Point(8, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Stream Link:";
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Red;
            this.ExitBtn.Location = new System.Drawing.Point(344, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(22, 24);
            this.ExitBtn.TabIndex = 47;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ShareTrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 241);
            this.Controls.Add(this.Track1Name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShareTrackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShareTrackForm";
            this.Load += new System.EventHandler(this.ShareTrackForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Track1Name;
        private System.Windows.Forms.TextBox TrackEmailTbx;
        private System.Windows.Forms.Button ShareBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TrackLinkTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Label TrackArtistLbl;
        private System.Windows.Forms.Label TrackNameLbl;
        private System.Windows.Forms.Label label4;
    }
}