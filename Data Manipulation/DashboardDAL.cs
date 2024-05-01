using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Employees_Management_System.Data_Manipulation
{
    internal class DashboardDAL
    {
        public int CountAllEmployees()
        {
            int count = 0;

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "SELECT COUNT(*) FROM employees";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return count;
        }

        public int CountInactiveEmployees()
        {
            int count = 0;

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    //string sql = "SELECT COUNT(*) FROM employees WHERE status = 'Inactive'";
                    string sql = "SELECT COUNT(*) FROM employees WHERE status LIKE 'Inactive%'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return count;
        }

        public int CountActiveEmployee()
        {
            int count = 0;

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "SELECT COUNT(*) FROM employees WHERE status LIKE 'Active%'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return count;
        }
    }
}
