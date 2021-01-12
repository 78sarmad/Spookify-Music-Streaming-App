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
    public partial class SignUpScreen : Form
    {
        Operations DBO;
        bool nameError, emailError, pwdError;

        public SignUpScreen()
        {
            InitializeComponent();
            DBO = new Operations();
            nameError = true;
            emailError = true;
            pwdError = true;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AltSignInBtn_Click(object sender, EventArgs e)
        {
            SignInScreen SIS = new SignInScreen();
            SIS.Show();
            this.Close();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (!nameError && !emailError && !pwdError)
            {
                bool isSuccessful = DBO.signUp(NameInput.Text, EmailInput.Text, PasswordInput.Text);
                if (isSuccessful)
                {
                    MessageBox.Show("Sign up successful. Please sign in.", "Success");
                    SignInScreen SIS = new SignInScreen();
                    SIS.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sign up failed. Please retry.", "Error");
                }
            }
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            if (NameInput.Text == "")
            {
                Session.ErrProv.SetError(NameInput, "Name cannot be empty");
                nameError = true;
            }
            else
            {
                Session.ErrProv.Clear();
                nameError = false;
            }
        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {
            if (EmailInput.Text == "")
            {
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
