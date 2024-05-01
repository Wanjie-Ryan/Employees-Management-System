using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees_Management_System.Data_Logics;
using Employees_Management_System.Data_Manipulation;

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
            if (
                string.IsNullOrEmpty(txtEmpID.Text)
                || string.IsNullOrEmpty(txtFullname.Text)
                || string.IsNullOrEmpty(cmbGender.Text)
                || string.IsNullOrEmpty(txtphoneNumber.Text)
                || string.IsNullOrEmpty(cmbPosition.Text)
                || string.IsNullOrEmpty(cmbStatus.Text)
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

            int salary = 0;

            empBLL.employeeId = int.Parse(txtEmpID.Text);
            empBLL.fullname = txtFullname.Text;
            empBLL.gender = cmbGender.Text;
            empBLL.phone = txtphoneNumber.Text;
            empBLL.position = cmbPosition.Text;
            empBLL.status = cmbStatus.Text;
            empBLL.salary = salary;

            bool success = empDAL.Insert(empBLL);

            if (success == true)
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

        private void DGVEmpData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rows = e.RowIndex;

            txtEmpID.Text = DGVEmpData.Rows[rows].Cells[0].Value.ToString();
            txtFullname.Text = DGVEmpData.Rows[rows].Cells[1].Value.ToString();
            cmbGender.Text = DGVEmpData.Rows[rows].Cells[2].Value.ToString();
            txtphoneNumber.Text = DGVEmpData.Rows[rows].Cells[3].Value.ToString();
            cmbPosition.Text = DGVEmpData.Rows[rows].Cells[4].Value.ToString();
            cmbStatus.Text = DGVEmpData.Rows[rows].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DGVEmpData.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select an Employee from the list before attempting to Update.",
                    "No Employee Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return; // Exit the method if no row is selected
            }
            if (string.IsNullOrEmpty(txtEmpID.Text))
            {
                MessageBox.Show(
                    "Please Fill in all the fields.",
                    "Missing Fields",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Warning
                );
                return;
            }

            empBLL.employeeId = int.Parse(txtEmpID.Text);
            empBLL.fullname = txtFullname.Text;
            empBLL.gender = cmbGender.Text;
            empBLL.phone = txtphoneNumber.Text;
            empBLL.position = cmbPosition.Text;
            empBLL.status = cmbStatus.Text;

            bool Success = empDAL.Update(empBLL);

            if (Success == true)
            {
                MessageBox.Show(
                    "Employee Details Updated Successfully",
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
                    "Failed to Update Employee",
                    "Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DGVEmpData.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select an Employee from the list before attempting to Delete.",
                    "No Employee Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return; // Exit the method if no row is selected
            }
            if (string.IsNullOrEmpty(txtEmpID.Text))
            {
                MessageBox.Show(
                    "Please Fill in all the fields.",
                    "Missing Fields",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Warning
                );
                return;
            }

            empBLL.employeeId = int.Parse(txtEmpID.Text);

            bool success = empDAL.Delete(empBLL);

            if (success == true)
            {
                MessageBox.Show(
                    "Employee Deleted Successfully",
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
                    "Failed to Delete Employee",
                    "Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword != "")
            {
                DataTable dt = empDAL.Search(keyword);
                DGVEmpData.DataSource = dt;
            }
            else
            {
                DataTable dt = empDAL.Select();
                DGVEmpData.DataSource = dt;
            }
        }
    }
}
