using Employees_Management_System.Data_Logics;
using Employees_Management_System.Data_Manipulation;
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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        SalaryBLL salbll = new SalaryBLL();
        SalaryDAL saldal = new SalaryDAL();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            DataTable dt = saldal.Select();
            dgvSalary.DataSource = dt;

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
        }
    }
}
