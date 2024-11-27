using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace windowforms_sqlsever
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        // Kết nối đến cơ sở dữ liệu
        private SqlConnection GetConnection()
        {
            string connectionString = "Data Source=DESKTOP-EK73N0M\\ECUSSQL2008;Initial Catalog=UserDatabase;Integrated Security=True";
            return new SqlConnection(connectionString);
        }

        // Kiểm tra tên tài khoản đã tồn tại trong cơ sở dữ liệu hay chưa
        private bool IsUsernameExist(string username)
        {
            bool exists = false;
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    exists = count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }

            return exists;
        }

        // Đăng ký tài khoản mới
        private void RegisterAccount(string username, string password)
        {
            string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Tài khoản đã được đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form đăng ký sau khi hoàn thành
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đăng ký tài khoản: " + ex.Message);
                }
            }
        }

        // Kiểm tra mật khẩu có hợp lệ không
        

        // Sự kiện khi nhấn nút Đăng ký
       

        // Kiểm tra khi thay đổi mật khẩu
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Kiểm tra khi thay đổi xác nhận mật khẩu
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnregiter_Click_1(object sender, EventArgs e)
        {
           
                string username = txtaccount.Text.Trim();
                string password = txtpass.Text.Trim();
                string confirmPassword = txtconfirmpass.Text.Trim();

                // Kiểm tra tên tài khoản đã tồn tại chưa
                if (IsUsernameExist(username))
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra mật khẩu và xác nhận mật khẩu có khớp hay không
                if (password != confirmPassword)
                {
                    MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Đăng ký tài khoản mới
                RegisterAccount(username, password);
            
        }
    }
}
