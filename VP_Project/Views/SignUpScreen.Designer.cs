namespace VP_Project
{
    partial class SignUpScreen
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
            this.label6 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.AltSignInBtn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EmailInput);
            this.panel1.Controls.Add(this.AltSignInBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SignUpBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PasswordInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NameInput);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 573);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 10F);
            this.label6.Location = new System.Drawing.Point(601, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email: *";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(727, 306);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(199, 22);
            this.EmailInput.TabIndex = 14;
            this.EmailInput.TextChanged += new System.EventHandler(this.EmailInput_TextChanged);
            // 
            // AltSignInBtn
            // 
            this.AltSignInBtn.AutoSize = true;
            this.AltSignInBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F);
            this.AltSignInBtn.ForeColor = System.Drawing.Color.Navy;
            this.AltSignInBtn.Location = new System.Drawing.Point(893, 70);
            this.AltSignInBtn.Name = "AltSignInBtn";
            this.AltSignInBtn.Size = new System.Drawing.Size(60, 20);
            this.AltSignInBtn.TabIndex = 13;
            this.AltSignInBtn.Text = "Sign In";
            this.AltSignInBtn.Click += new System.EventHandler(this.AltSignInBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(733, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Already a member?";
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.Navy;
            this.SignUpBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.Location = new System.Drawing.Point(819, 386);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(107, 40);
            this.SignUpBtn.TabIndex = 11;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 10F);
            this.label3.Location = new System.Drawing.Point(601, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password: *";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(727, 342);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(199, 22);
            this.PasswordInput.TabIndex = 9;
            this.PasswordInput.TextChanged += new System.EventHandler(this.PasswordInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 10F);
            this.label2.Location = new System.Drawing.Point(601, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name: *";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(727, 269);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(199, 22);
            this.NameInput.TabIndex = 7;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
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
            this.label1.Size = new System.Drawing.Size(257, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sign Up to Spookify";
            // 
            // SignUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AltSignInBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmailInput;

    }
}

