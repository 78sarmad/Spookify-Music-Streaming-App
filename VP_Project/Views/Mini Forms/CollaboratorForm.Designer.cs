namespace VP_Project.Views.Mini_Forms
{
    partial class CollaboratorForm
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
            this.ChangeCollabBtn = new System.Windows.Forms.Button();
            this.NewCollabInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentCollabTbx = new System.Windows.Forms.TextBox();
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
            this.Track1Name.Size = new System.Drawing.Size(203, 24);
            this.Track1Name.TabIndex = 46;
            this.Track1Name.Text = "Manage Collaborators";
            // 
            // ChangeCollabBtn
            // 
            this.ChangeCollabBtn.BackColor = System.Drawing.Color.Navy;
            this.ChangeCollabBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.ChangeCollabBtn.ForeColor = System.Drawing.Color.White;
            this.ChangeCollabBtn.Location = new System.Drawing.Point(263, 94);
            this.ChangeCollabBtn.Name = "ChangeCollabBtn";
            this.ChangeCollabBtn.Size = new System.Drawing.Size(97, 28);
            this.ChangeCollabBtn.TabIndex = 47;
            this.ChangeCollabBtn.Text = "CHANGE";
            this.ChangeCollabBtn.UseVisualStyleBackColor = false;
            this.ChangeCollabBtn.Click += new System.EventHandler(this.ChangeCollabBtn_Click);
            // 
            // NewCollabInput
            // 
            this.NewCollabInput.Location = new System.Drawing.Point(12, 97);
            this.NewCollabInput.Name = "NewCollabInput";
            this.NewCollabInput.Size = new System.Drawing.Size(237, 22);
            this.NewCollabInput.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CurrentCollabTbx);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NewCollabInput);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.ChangeCollabBtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 142);
            this.panel1.TabIndex = 48;
            // 
            // CurrentCollabTbx
            // 
            this.CurrentCollabTbx.Enabled = false;
            this.CurrentCollabTbx.Location = new System.Drawing.Point(117, 57);
            this.CurrentCollabTbx.Name = "CurrentCollabTbx";
            this.CurrentCollabTbx.Size = new System.Drawing.Size(243, 22);
            this.CurrentCollabTbx.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 8F);
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Collaborator:";
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
            // CollaboratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 148);
            this.Controls.Add(this.Track1Name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CollaboratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePlaylistForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CollaboratorForm_FormClosed);
            this.Load += new System.EventHandler(this.CollaboratorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Track1Name;
        private System.Windows.Forms.Button ChangeCollabBtn;
        private System.Windows.Forms.TextBox NewCollabInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CurrentCollabTbx;
    }
}