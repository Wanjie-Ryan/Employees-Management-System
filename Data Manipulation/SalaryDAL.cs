using Employees_Management_System.Data_Logics;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees_Management_System.Data_Manipulation
{
    internal class SalaryDAL
    {
        public DataTable Select()
        {
            DataTable dt = new DataTable();

            using(MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "SELECT * FROM employees";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return dt;
        }

        public bool Update(SalaryBLL s)
        {
            bool Success = false;

            using(MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "UPDATE employees SET salary = @salary WHERE employee_id = @employee_id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@salary", s.salary);
                    cmd.Parameters.AddWithValue("@employee_id", s.employeeId);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        Success = true;
                    }
                    else
                    {
                        Success = false;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return Success;
        }

        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();

            using(MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "SELECT * FROM employees WHERE fullname LIKE '%" +keyword+ "%' OR position LIKE '%" + keyword+ "%' OR gender LIKE '%" +keyword+ "%' ";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }


            return dt;
        }
    }
}
