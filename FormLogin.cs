﻿using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace windowforms_sqlsever
{
    public partial class FormLogin : Form
    {
        public bool IsAuthenticated { get; private set; } = false; // Trạng thái đăng nhập

        public FormLogin()
        {
            InitializeComponent();
        }


        // Hàm kết nối cơ sở dữ liệu SQL Server
        private SQLiteConnection GetConnection()
        {
            return DatabaseHelper1.GetConnection(); // Sử dụng phương thức tĩnh để lấy kết nối
        }

        // Hàm kiểm tra đăng nhập với cơ sở dữ liệu
        private bool AuthenticateUser(string username, string password)
        {
            bool isAuthenticated = false;

            // Câu truy vấn kiểm tra tên tài khoản và mật khẩu
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

            using (SQLiteConnection connection = GetConnection())
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password); // Lưu ý rằng mật khẩu chưa được mã hóa, cần mã hóa trong thực tế

                try
                {
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar()); // Đếm số lượng bản ghi khớp
                    isAuthenticated = count > 0; // Nếu số lượng bản ghi > 0, tài khoản hợp lệ
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isAuthenticated;
        }

        // Sự kiện khi nhấn nút "Login"
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtaccount.Text.Trim(); // Lấy tên tài khoản từ ô nhập
            string password = txtpass.Text.Trim(); // Lấy mật khẩu từ ô nhập

            // Kiểm tra thông tin đăng nhập từ cơ sở dữ liệu
            if (AuthenticateUser(username, password))
            {
                IsAuthenticated = true; // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form đăng nhập
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi nhấn nút "Đăng ký"
        private void button2_Click(object sender, EventArgs e)
        {
            FormRegister registerForm = new FormRegister();
            registerForm.ShowDialog(); // Mở form đăng ký
        }
    }
}
