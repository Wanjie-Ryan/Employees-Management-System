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
using Org.BouncyCastle.Asn1.Cmp;

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

            if (keyword != "")
            {
                DataTable dt = saldal.Search(keyword);
                dgvSalary.DataSource = dt;
            }
            else
            {
                DataTable dt = saldal.Select();
                dgvSalary.DataSource = dt;
            }
        }

        private void dgvSalary_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rows = e.RowIndex;

            txtEmpID.Text = dgvSalary.Rows[rows].Cells[0].Value.ToString();
            txtFullname.Text = dgvSalary.Rows[rows].Cells[1].Value.ToString();
            txtPosition.Text = dgvSalary.Rows[rows].Cells[4].Value.ToString();
            txtSalary.Text = dgvSalary.Rows[rows].Cells[6].Value.ToString();
        }

        public void Clear()
        {
            txtEmpID.Text = "";
            txtFullname.Text = "";
            txtPosition.Text = "";
            txtSalary.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSalary.SelectedRows.Count == 0)
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

            salbll.employeeId = int.Parse(txtEmpID.Text);
            salbll.salary = float.Parse(txtSalary.Text);

            bool success = saldal.Update(salbll);

            if (success == true)
            {
                MessageBox.Show(
                    "Employee Details Updated Successfully",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                DataTable dt = saldal.Select();
                dgvSalary.DataSource = dt;
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
    }
}
