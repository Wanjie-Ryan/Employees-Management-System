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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        EmployeeBLL empBLL = new EmployeeBLL();
        EmployeeDAL empDAL = new EmployeeDAL();
        private void btnSalary_Click(object sender, EventArgs e)
        {
            Salary salaryform = new Salary();
            salaryform.Show();
        }

        private void label8_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txtEmpID.Text = "";
            txtFullname.Text = "";
            cmbGender.Text = "";
            txtphoneNumber.Text = "";
            cmbPosition.Text = "";
            cmbStatus.Text = "";
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            DataTable dt = empDAL.Select();
            DGVEmpData.DataSource = dt;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtEmpID.Text) || string.IsNullOrEmpty(txtFullname.Text) || string.IsNullOrEmpty(cmbGender.Text) || string.IsNullOrEmpty(txtphoneNumber.Text) || string.IsNullOrEmpty(cmbPosition.Text) || string.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show(
                    "Please Fill in all the fields.",
                    "Missing Fields",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int salary = 0;

            empBLL.employeeId = int.Parse(txtEmpID.Text);
            empBLL.fullname = txtFullname.Text;
            empBLL.gender = cmbGender.Text;
            empBLL.phone = txtphoneNumber.Text;
            empBLL.position = cmbPosition.Text;
            empBLL.status = cmbStatus.Text;
            empBLL.salary = salary;

            bool success = empDAL.Insert(empBLL);

            if(success == true)
            {
                MessageBox.Show(
                   "Employee Added Successfully",
                   "Success",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
               );

                DataTable dt = empDAL.Select();
                DGVEmpData.DataSource = dt;
                Clear();

            }
            else
            {
                MessageBox.Show(
                   "Failed to Add Employee",
                   "Failed",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }
    }
}
