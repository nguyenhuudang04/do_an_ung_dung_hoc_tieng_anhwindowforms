using System;
using System.Data.SQLite; // Hoặc Microsoft.Data.Sqlite nếu bạn sử dụng gói của Microsoft
using System.IO;

namespace windowforms_sqlsever
{
    public class DatabaseHelper1
    {
        public static SQLiteConnection GetConnection()
        {
            // Đường dẫn đến thư mục .db trong thư mục chứa ứng dụng
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".db");

            // Kiểm tra và tạo thư mục nếu không tồn tại
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Đường dẫn đến file cơ sở dữ liệu
            string databaseFile = Path.Combine(folderPath, "UsersDatabase.sqlite");

            // Tạo file cơ sở dữ liệu nếu chưa tồn tại
            if (!File.Exists(databaseFile))
            {
                SQLiteConnection.CreateFile(databaseFile);

                // Tạo bảng Users trong cơ sở dữ liệu
                using (var connection = new SQLiteConnection($"Data Source={databaseFile};Version=3;"))
                {
                    connection.Open();
                    string createTableQuery = "CREATE TABLE Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Username TEXT NOT NULL UNIQUE, Password TEXT NOT NULL);";
                    SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            // Trả về kết nối đến cơ sở dữ liệu
            return new SQLiteConnection($"Data Source={databaseFile};Version=3;");
        }
    }
}
