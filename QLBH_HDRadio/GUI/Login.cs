using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;


namespace QLBH_HDRadio
{
    public partial class Login : Form
    {
        // Kết nối đến cơ sở dữ liệu SQL Server
        string connectionString = "Data Source=LAPTOP-R0NEHT21\\SQLEXPRESS;Initial Catalog=QLBHHDRadio;User ID=sa;Password=sa;";

        public Login()
        {
            InitializeComponent();
        }

        private void btt_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btdn_Click(object sender, EventArgs e)
        {
            string username = tuser.Text;
            string password = tpass.Text;

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Logins WHERE username=@username AND password=@password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int result = (int)command.ExecuteScalar();
                if (result > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    new Main().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại thông tin đăng nhập.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
