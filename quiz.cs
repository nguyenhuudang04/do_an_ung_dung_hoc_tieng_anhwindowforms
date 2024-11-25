using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowforms_sqlsever
{
    internal class Quiz
    {
        
        public static DataTable GetQuizzes()
        {
            string query = "SELECT QuizId, QuizName, CreatedDate FROM Quizzes";
            return DatabaseHelper.ExecuteQuery(query);
        }

        
        public static bool AddQuiz(string quizName, int createdBy)
        {
            try
            {
                string query = @"INSERT INTO Quizzes (QuizName, CreatedBy, CreatedDate)
                                 VALUES (@QuizName, @CreatedBy, GETDATE())";

                SqlParameter[] parameters = {
                    new SqlParameter("@QuizName", quizName),
                    new SqlParameter("@CreatedBy", createdBy)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    Console.WriteLine("Thêm câu đố thành công!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi thêm câu đố.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

        
        public static bool UpdateQuiz(int quizId, string quizName)
        {
            try
            {
                string query = @"UPDATE Quizzes
                                 SET QuizName = @QuizName
                                 WHERE QuizId = @QuizId";

                SqlParameter[] parameters = {
                    new SqlParameter("@QuizId", quizId),
                    new SqlParameter("@QuizName", quizName)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    Console.WriteLine("Cập nhật câu đố thành công!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi cập nhật câu đố.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

        
        public static bool DeleteQuiz(int quizId)
        {
            try
            {
                string query = "DELETE FROM Quizzes WHERE QuizId = @QuizId";

                SqlParameter[] parameters = {
                    new SqlParameter("@QuizId", quizId)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    Console.WriteLine("Xóa câu đố thành công!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi xóa câu đố.");
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
