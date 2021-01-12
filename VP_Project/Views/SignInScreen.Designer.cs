namespace VP_Project
{
    partial class SignInScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.AltSignUpBtn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.StatusLbl);
            this.panel1.Controls.Add(this.AltSignUpBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SignInBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PasswordInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EmailInput);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 573);
            this.panel1.TabIndex = 0;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Montserrat", 9F);
            this.StatusLbl.Location = new System.Drawing.Point(703, 361);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(95, 21);
            this.StatusLbl.TabIndex = 14;
            this.StatusLbl.Text = "Signing In...";
            this.StatusLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.StatusLbl.Visible = false;
            // 
            // AltSignUpBtn
            // 
            this.AltSignUpBtn.AutoSize = true;
            this.AltSignUpBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F);
            this.AltSignUpBtn.ForeColor = System.Drawing.Color.Navy;
            this.AltSignUpBtn.Location = new System.Drawing.Point(893, 70);
            this.AltSignUpBtn.Name = "AltSignUpBtn";
            this.AltSignUpBtn.Size = new System.Drawing.Size(67, 20);
            this.AltSignUpBtn.TabIndex = 13;
            this.AltSignUpBtn.Text = "Sign Up";
            this.AltSignUpBtn.Click += new System.EventHandler(this.AltSignUpBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(763, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Not a member?";
            // 
            // SignInBtn
            // 
            this.SignInBtn.BackColor = System.Drawing.Color.Navy;
            this.SignInBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBtn.ForeColor = System.Drawing.Color.White;
            this.SignInBtn.Location = new System.Drawing.Point(819, 351);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(107, 40);
            this.SignInBtn.TabIndex = 11;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = false;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 10F);
            this.label3.Location = new System.Drawing.Point(601, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(716, 307);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(210, 22);
            this.PasswordInput.TabIndex = 9;
            this.PasswordInput.TextChanged += new System.EventHandler(this.PasswordInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 10F);
            this.label2.Location = new System.Drawing.Point(601, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email:";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(716, 269);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(210, 22);
            this.EmailInput.TabIndex = 7;
            this.EmailInput.TextChanged += new System.EventHandler(this.EmailInput_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::VP_Project.Properties.Resources.signup_in;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 566);
            this.panel2.TabIndex = 6;
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Red;
            this.ExitBtn.Location = new System.Drawing.Point(992, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(22, 24);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 14F);
            this.label1.Location = new System.Drawing.Point(574, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sign In to Spookify";
            // 
            // SignInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignInScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AltSignUpBtn;
        private System.Windows.Forms.Label StatusLbl;

    }
}

