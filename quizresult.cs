using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowforms_sqlsever
{
    internal class QuizResult
    {
        
        public static DataTable GetUserQuizResults(int userId)
        {
            string query = @"SELECT qr.QuizId, q.QuizName, qr.Score, qr.CompletedDate
                             FROM QuizResults qr
                             INNER JOIN Quizzes q ON qr.QuizId = q.QuizId
                             WHERE qr.UserId = @UserId
                             ORDER BY qr.CompletedDate DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@UserId", userId)
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

       
        public static bool AddQuizResult(int quizId, int userId, int score)
        {
            try
            {
                string query = @"INSERT INTO QuizResults (QuizId, UserId, Score, CompletedDate)
                                 VALUES (@QuizId, @UserId, @Score, GETDATE())";

                SqlParameter[] parameters = {
                    new SqlParameter("@QuizId", quizId),
                    new SqlParameter("@UserId", userId),
                    new SqlParameter("@Score", score)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    Console.WriteLine("Kết quả quiz đã được thêm thành công!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi thêm kết quả quiz.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

        
        public static bool UpdateQuizResult(int resultId, int score)
        {
            try
            {
                string query = @"UPDATE QuizResults
                                 SET Score = @Score
                                 WHERE ResultId = @ResultId";

                SqlParameter[] parameters = {
                    new SqlParameter("@ResultId", resultId),
                    new SqlParameter("@Score", score)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    Console.WriteLine("Cập nhật kết quả quiz thành công!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi cập nhật kết quả quiz.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

        
        public static bool DeleteQuizResult(int resultId)
        {
            try
            {
                string query = "DELETE FROM QuizResults WHERE ResultId = @ResultId";

                SqlParameter[] parameters = {
                    new SqlParameter("@ResultId", resultId)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    Console.WriteLine("Kết quả quiz đã được xóa thành công!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi xóa kết quả quiz.");
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
