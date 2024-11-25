using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace windowforms_sqlsever
{
    internal class User
    {
        
        public static DataTable GetUsers()
        {
            string query = "SELECT UserId, Username, Email, CreatedDate FROM Users";
            return DatabaseHelper.ExecuteQuery(query);
        }

        
        public static bool AddUser(string username, string email, string password)
        {
            try
            {
                string hashedPassword = HashPassword(password); // Mã hóa mật khẩu
                string query = @"INSERT INTO Users (Username, Email, Password, CreatedDate)
                                 VALUES (@Username, @Email, @Password, GETDATE())";

                SqlParameter[] parameters = {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Password", hashedPassword)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    Console.WriteLine("Thêm người dùng thành công!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi thêm người dùng.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

        
        public static bool UpdateUser(int userId, string username, string email)
        {
            try
            {
                string query = @"UPDATE Users
                                 SET Username = @Username, Email = @Email
                                 WHERE UserId = @UserId";

                SqlParameter[] parameters = {
                    new SqlParameter("@UserId", userId),
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Email", email)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    Console.WriteLine("Cập nhật thông tin người dùng thành công!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi cập nhật thông tin người dùng.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

        
        public static bool DeleteUser(int userId)
        {
            try
            {
                string query = "DELETE FROM Users WHERE UserId = @UserId";

                SqlParameter[] parameters = {
                    new SqlParameter("@UserId", userId)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    Console.WriteLine("Xóa người dùng thành công!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi xóa người dùng.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

        
        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder hashString = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashString.Append(b.ToString("x2")); 
                }
                return hashString.ToString();
            }
        }

        
        public static bool ValidateUser(string username, string password)
        {
            try
            {
                string query = "SELECT Password FROM Users WHERE Username = @Username";
                SqlParameter[] parameters = { new SqlParameter("@Username", username) };
                DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    string storedHash = result.Rows[0]["Password"].ToString();
                    string hashedPassword = HashPassword(password);

                    if (storedHash == hashedPassword)
                    {
                        Console.WriteLine("Đăng nhập thành công!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Mật khẩu không chính xác.");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Tài khoản không tồn tại.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }
    }
}
