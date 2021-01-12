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
        bool emailError, pwdError;
        public SignInScreen()
        {
            InitializeComponent();
            emailError = true;
            pwdError = true;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            if (!emailError && !pwdError)
            {
                StatusLbl.Visible = true;
                String email = EmailInput.Text.Trim();
                String pwd = PasswordInput.Text.Trim();

                Operations DBO = new Operations();
                if (DBO.trySignIn(email, pwd) == true)
                {
                    HomeScreen HS = new HomeScreen();
                    HS.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect credentials. Please retry.", "Sign In Failed");
                }
            }
        }

        private void AltSignUpBtn_Click(object sender, EventArgs e)
        {
            SignUpScreen SUS = new SignUpScreen();
            SUS.Show();
            this.Close();
        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {
            if (EmailInput.Text == ""){
                Session.ErrProv.SetError(EmailInput, "Email cannot be empty");
                emailError = true;
            }
            else
            {
                Session.ErrProv.Clear();
                emailError = false;
            }
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
            if (PasswordInput.Text == "")
            {
                Session.ErrProv.SetError(PasswordInput, "Password cannot be empty");
                pwdError = true;
            }
            else
            {
                Session.ErrProv.Clear();
                pwdError = false;
            }
        }
    }
}
