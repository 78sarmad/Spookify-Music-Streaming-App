namespace VP_Project.Views.Mini_Forms
{
    partial class CreatePlaylistForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreatePlaylistBtn = new System.Windows.Forms.Button();
            this.PlaylistNameInput = new System.Windows.Forms.TextBox();
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
            this.Track1Name.Size = new System.Drawing.Size(182, 24);
            this.Track1Name.TabIndex = 46;
            this.Track1Name.Text = "Create New Playlist";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CreatePlaylistBtn);
            this.panel1.Controls.Add(this.PlaylistNameInput);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 131);
            this.panel1.TabIndex = 48;
            // 
            // CreatePlaylistBtn
            // 
            this.CreatePlaylistBtn.BackColor = System.Drawing.Color.Navy;
            this.CreatePlaylistBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.CreatePlaylistBtn.ForeColor = System.Drawing.Color.White;
            this.CreatePlaylistBtn.Location = new System.Drawing.Point(186, 91);
            this.CreatePlaylistBtn.Name = "CreatePlaylistBtn";
            this.CreatePlaylistBtn.Size = new System.Drawing.Size(80, 28);
            this.CreatePlaylistBtn.TabIndex = 50;
            this.CreatePlaylistBtn.Text = "CREATE";
            this.CreatePlaylistBtn.UseVisualStyleBackColor = false;
            this.CreatePlaylistBtn.Click += new System.EventHandler(this.CreatePlaylistBtn_Click);
            // 
            // PlaylistNameInput
            // 
            this.PlaylistNameInput.Location = new System.Drawing.Point(12, 53);
            this.PlaylistNameInput.Name = "PlaylistNameInput";
            this.PlaylistNameInput.Size = new System.Drawing.Size(254, 22);
            this.PlaylistNameInput.TabIndex = 49;
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Red;
            this.ExitBtn.Location = new System.Drawing.Point(249, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(22, 24);
            this.ExitBtn.TabIndex = 47;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CreatePlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 135);
            this.Controls.Add(this.Track1Name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreatePlaylistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePlaylistForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Track1Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.TextBox PlaylistNameInput;
        private System.Windows.Forms.Button CreatePlaylistBtn;
    }
}