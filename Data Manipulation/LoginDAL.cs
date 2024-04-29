using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees_Management_System.Data_Logics;
using MySql.Data.MySqlClient;

namespace Employees_Management_System.Data_Manipulation
{
    internal class LoginDAL
    {
        public bool Login(LoginBLL l)
        {
            bool isSuccess = false;
            bool verifiedPwd = false;

            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                try
                {
                    string sql = "SELECT password FROM users WHERE email = @email";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@email", l.email);

                    conn.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string hashedPassword = result.ToString();
                        verifiedPwd = BCrypt.Net.BCrypt.Verify(l.password, hashedPassword);
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
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

            return isSuccess;
        }
    }
}
