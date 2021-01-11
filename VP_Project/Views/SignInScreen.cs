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

namespace VP_Project
{
    public partial class SignInScreen : Form
    {
        public SignInScreen()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            StatusLbl.Visible = true;
            String email = EmailInput.Text.Trim();
            String pwd = PasswordInput.Text.Trim();

            Operations DBO = new Operations();
            if (DBO.trySignIn(email, pwd) == true)
            {
                HomeScreen HS = new HomeScreen();
                HS.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Incorrect credentials. Please retry.", "Sign In Failed");
            }
        }

        private void AltSignUpBtn_Click(object sender, EventArgs e)
        {
            SignUpScreen SUS = new SignUpScreen();
            SUS.Show();
            this.Dispose();
        }
    }
}
