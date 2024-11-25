using System;
using System.Windows.Forms;

namespace windowforms_sqlsever
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Hiển thị FormLogin
            FormLogin loginForm = new FormLogin();
            Application.Run(loginForm);

            // Nếu đăng nhập thành công, mở Form1
            if (loginForm.IsAuthenticated)
            {
                Application.Run(new Form1());
            }
        }
    }
}
