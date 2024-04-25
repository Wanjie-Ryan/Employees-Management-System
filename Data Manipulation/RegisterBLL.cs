using Employees_Management_System.Data_Logics;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees_Management_System.Data_Manipulation
{
    internal class RegisterBLL
    {
        public bool Register(RegisterDLL r)
        {
            using (MySqlConnection conn = new MySqlConnection(Program.GetConnectionString()))
            {
                bool isSuccess = false;
                try
                {
                    string hashedpassword = BCrypt.Net.BCrypt.EnhancedHashPassword(r.password);
                    string sql = "INSERT INTO users (userId, username, email, password) VALUES (@userId, @username, @email, @password)";
                    MySqlCommand cmd = new MySqlCommand(sql,conn);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return isSuccess;
            }

        }
    }
}
