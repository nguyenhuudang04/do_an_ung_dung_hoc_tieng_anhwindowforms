using System;
using System.Windows.Forms;

namespace windowforms_sqlsever
{
    public partial class FormLogin : Form
    {
        public bool IsAuthenticated { get; private set; } = false; // Trạng thái đăng nhập

        public FormLogin()
        {
            InitializeComponent();
            button1.Click += button1_Click; // Gán sự kiện cho nút "Log in"
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text; // Lấy giá trị từ ô tài khoản
            string password = textBox2.Text; // Lấy giá trị từ ô mật khẩu

            // Kiểm tra thông tin đăng nhập (ở đây sử dụng dữ liệu cố định)
            if (username == "admin" && password == "12345")
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

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegister registerForm = new FormRegister();
            registerForm.ShowDialog();
        }
    }
}
