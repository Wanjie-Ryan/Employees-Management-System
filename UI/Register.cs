﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees_Management_System.UI;

namespace Employees_Management_System.UI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
        }
    }
}
