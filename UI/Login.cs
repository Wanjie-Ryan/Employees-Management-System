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

namespace Employees_Management_System.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        LoginBLL login = new LoginBLL();
        LoginDAL logdal = new LoginDAL();
        public static string identityname;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPwd.Text))
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
            login.email = txtEmail.Text;
            login.password = txtPwd.Text;
            identityname = txtEmail.Text.Trim();

            int atIndex = identityname.IndexOf('@');
            if (atIndex != -1)
            {
                identityname = identityname.Substring(0, atIndex);
            }

            bool success = logdal.Login(login);

            if (success == true)
            {
                MessageBox.Show(
                    "Login Successful",
                    "Login Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Dashboard dashform = new Dashboard();
                dashform.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Invalid Email or Password",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

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
