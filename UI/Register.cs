using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees_Management_System.Data_Logics;
using Employees_Management_System.Data_Manipulation;
using Employees_Management_System.UI;
using Org.BouncyCastle.Bcpg.Sig;

namespace Employees_Management_System.UI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        RegisterDLL regDLL = new RegisterDLL();
        RegisterBLL regBLL = new RegisterBLL();
        public static string identityname;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(txtUsername.Text)
                || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(txtPwd.Text)
            )
            {
                MessageBox.Show(
                    "Please Fill in all the fields.",
                    "Missing Fields",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@]+@(gmail|yahoo)\.com$"))
            {
                MessageBox.Show(
                    "Please enter a valid Gmail or Yahoo email address.",
                    "Invalid Email Address",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (txtPwd.Text.Length < 6)
            {
                MessageBox.Show(
                    "The length of the password must be more than 6 characters",
                    "Short Password",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Warning
                );
                return;
            }

            regDLL.username = txtUsername.Text;
            regDLL.email = txtEmail.Text;
            regDLL.password = txtPwd.Text;
            identityname = txtUsername.Text;

            bool Success = regBLL.Register(regDLL);

            if (Success == true)
            {
                MessageBox.Show(
                    "Registration Successful",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Login loginform = new Login();
                loginform.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Registration Failed",
                    "Failure",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
        }

        // TOGGLING THE PASSWORD
        private void cbShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPwd.Checked)
            {
                txtPwd.PasswordChar = '\0'; // Show password
            }
            else
            {
                txtPwd.PasswordChar = '*'; // Hide password
            }
        }
    }
}
