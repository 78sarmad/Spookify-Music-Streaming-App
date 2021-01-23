namespace VP_Project.Views.Mini_Forms
{
    partial class SearchTrackForm
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
            this.TrackResultsLbx = new System.Windows.Forms.ListBox();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchOnlineBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Track1Name
            // 
            this.Track1Name.AutoSize = true;
            this.Track1Name.Font = new System.Drawing.Font("Montserrat SemiBold", 10F);
            this.Track1Name.Location = new System.Drawing.Point(13, 20);
            this.Track1Name.Name = "Track1Name";
            this.Track1Name.Size = new System.Drawing.Size(141, 24);
            this.Track1Name.TabIndex = 52;
            this.Track1Name.Text = "Search Results";
            // 
            // TrackResultsLbx
            // 
            this.TrackResultsLbx.FormattingEnabled = true;
            this.TrackResultsLbx.ItemHeight = 16;
            this.TrackResultsLbx.Location = new System.Drawing.Point(13, 58);
            this.TrackResultsLbx.Name = "TrackResultsLbx";
            this.TrackResultsLbx.Size = new System.Drawing.Size(258, 148);
            this.TrackResultsLbx.TabIndex = 51;
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.Navy;
            this.PlayBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.PlayBtn.ForeColor = System.Drawing.Color.White;
            this.PlayBtn.Location = new System.Drawing.Point(191, 218);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(80, 28);
            this.PlayBtn.TabIndex = 53;
            this.PlayBtn.Text = "PLAY";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SearchOnlineBtn);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 252);
            this.panel1.TabIndex = 54;
            // 
            // SearchOnlineBtn
            // 
            this.SearchOnlineBtn.BackColor = System.Drawing.Color.Navy;
            this.SearchOnlineBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.SearchOnlineBtn.ForeColor = System.Drawing.Color.White;
            this.SearchOnlineBtn.Location = new System.Drawing.Point(8, 215);
            this.SearchOnlineBtn.Name = "SearchOnlineBtn";
            this.SearchOnlineBtn.Size = new System.Drawing.Size(159, 28);
            this.SearchOnlineBtn.TabIndex = 55;
            this.SearchOnlineBtn.Text = "SEARCH ONLINE";
            this.SearchOnlineBtn.UseVisualStyleBackColor = false;
            this.SearchOnlineBtn.Click += new System.EventHandler(this.SearchOnlineBtn_Click);
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
            // SearchTrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(283, 255);
            this.Controls.Add(this.Track1Name);
            this.Controls.Add(this.TrackResultsLbx);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchTrackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Track";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchTrackForm_FormClosed);
            this.Load += new System.EventHandler(this.SearchTrackForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Track1Name;
        private System.Windows.Forms.ListBox TrackResultsLbx;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Button SearchOnlineBtn;
    }
}