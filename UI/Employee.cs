using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees_Management_System.UI
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Salary salaryform = new Salary();
            salaryform.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string greeting;
            if (now.Hour >= 0 && now.Hour < 12)
            {
                greeting = "Good Morning";
            }
            else if (now.Hour >= 12 && now.Hour < 16)
            {
                greeting = "Good Afternoon";
            }
            else
            {
                greeting = "Good Evening";
            }
            lblTime.Text = $"{greeting} {Login.identityname}";
            //lblusername.Text = Login.identityname;
        }
    }
}
