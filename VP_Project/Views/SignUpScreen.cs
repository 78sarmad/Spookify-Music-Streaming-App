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

        public SignUpScreen()
        {
            InitializeComponent();
            DBO = new Operations();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AltSignInBtn_Click(object sender, EventArgs e)
        {
            SignInScreen SIS = new SignInScreen();
            SIS.Show();
            this.Dispose();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (DBO.signUp(NameInput.Text, EmailInput.Text, PasswordInput.Text) == true)
            {
                MessageBox.Show("Sign up successful. Please sign in.", "Success");
                SignInScreen SIS = new SignInScreen();
                SIS.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Sign up failed. Please retry.", "Error");
            }
        }
    }
}
