using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees_Management_System.Data_Logics;
using MySql.Data.MySqlClient;

namespace Employees_Management_System.Data_Manipulation
{
    internal class EmployeeDAL
    {
        public DataTable Select()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "SELECT * FROM employees";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
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

            return dt;
        }

        public bool Insert(EmployeeBLL e)
        {
            bool Success = false;

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql =
                        "INSERT INTO employees (employee_id, fullname, gender, phone, position, status, salary) VALUES (@employee_id, @fullname, @gender, @phone, @position, @status, @salary)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@employee_id", e.employeeId);
                    cmd.Parameters.AddWithValue("@fullname", e.fullname);
                    cmd.Parameters.AddWithValue("@gender", e.gender);
                    cmd.Parameters.AddWithValue("@phone", e.phone);
                    cmd.Parameters.AddWithValue("@position", e.position);
                    cmd.Parameters.AddWithValue("@status", e.status);
                    cmd.Parameters.AddWithValue("@salary", e.salary);

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
                catch (Exception ex)
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

        public bool Update(EmployeeBLL e)
        {
            bool Success = false;

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql =
                        "UPDATE employees SET fullname = @fullname, gender =@gender, phone = @phone, position = @position, status =@status, salary =@salary WHERE employee_id = @employee_id ";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@employee_id", e.employeeId);
                    cmd.Parameters.AddWithValue("@fullname", e.fullname);
                    cmd.Parameters.AddWithValue("@gender", e.gender);
                    cmd.Parameters.AddWithValue("@phone", e.phone);
                    cmd.Parameters.AddWithValue("@position", e.position);
                    cmd.Parameters.AddWithValue("@status", e.status);
                    cmd.Parameters.AddWithValue("@salary", e.salary);

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
                catch (Exception ex)
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

        public bool Delete(EmployeeBLL e)
        {
            bool Success = false;

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "DELETE FROM employees WHERE employee_id = @employee_id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@employee_id", e.employeeId);

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
                catch (Exception ex)
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

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql =
                        "SELECT * FROM employees WHERE employee_id LIKE '%"
                        + keyword
                        + "%' OR fullname LIKE '%"
                        + keyword
                        + "%' OR position LIKE '%"
                        + keyword
                        + "%' OR status LIKE '%"
                        + keyword
                        + "%' OR gender LIKE '%"
                        + keyword
                        + "%' ";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
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
            return dt;
        }
    }
}
