using System;
using System.Data.SQLite;
using System.Security.Principal;
using System.Windows.Forms;

namespace windowforms_sqlsever
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        // Kết nối đến cơ sở dữ liệu SQLite thông qua DatabaseHelper
        private SQLiteConnection GetConnection()
        {
            return DatabaseHelper1.GetConnection(); // Sử dụng phương thức tĩnh để lấy kết nối
        }

        // Kiểm tra tên tài khoản đã tồn tại trong cơ sở dữ liệu
        private bool IsUsernameExist(string username)
        {
            bool exists = false;
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

            using (SQLiteConnection connection = GetConnection())
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                exists = count > 0;
            }

            return exists;
        }

        // Đăng ký tài khoản mới
        private void RegisterAccount(string username, string password)
        {
            string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

            using (SQLiteConnection connection = GetConnection())
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Tài khoản đã được đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form đăng ký sau khi hoàn thành
            }
        }

        // Sự kiện khi nhấn nút Đăng ký
       

        private void btnregiter_Click(object sender, EventArgs e)
        {
            string username = txtaccount.Text.Trim();
            string password = txtpass.Text.Trim();
            string confirmPassword = txtconfirmpass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại nếu có trường nhập liệu bị bỏ trống
            }

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

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void FormRegister_Load(object sender, EventArgs e)
        {
            // Cung cấp mô tả cho các điều khiển
            toolTip1.SetToolTip(txtaccount, "Nhập tên tài khoản của bạn");
            toolTip1.SetToolTip(txtpass, "Mật khẩu phải có ít nhất 8 ký tự");
            toolTip1.SetToolTip(txtconfirmpass, "Xác nhận lại mật khẩu của bạn");
          
        }

    }

}
