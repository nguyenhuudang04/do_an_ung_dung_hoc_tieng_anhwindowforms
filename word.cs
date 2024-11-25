using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowforms_sqlsever
{
    internal class Word
    {
        
        public static DataTable GetWords()
        {
            string query = "SELECT WordId, Word, Meaning FROM Words";
            return DatabaseHelper.ExecuteQuery(query);
        }

      
        public static bool AddWord(string word, string meaning, int createdBy)
        {
            try
            {
                string query = @"INSERT INTO Words (Word, Meaning, CreatedBy, CreatedDate) 
                         VALUES (@Word, @Meaning, @CreatedBy, GETDATE())";

                SqlParameter[] parameters = {
            new SqlParameter("@Word", word),
            new SqlParameter("@Meaning", meaning),
            new SqlParameter("@CreatedBy", createdBy)
        };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    Console.WriteLine("Thêm từ vựng thành công!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi thêm từ vựng.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }


      
        public static bool UpdateWord(int wordId, string word, string meaning)
        {
            try
            {
                string query = @"UPDATE Words
                                 SET Word = @Word, Meaning = @Meaning
                                 WHERE WordId = @WordId";

                SqlParameter[] parameters = {
                    new SqlParameter("@WordId", wordId),
                    new SqlParameter("@Word", word),
                    new SqlParameter("@Meaning", meaning)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    Console.WriteLine("Cập nhật từ vựng thành công!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi cập nhật từ vựng.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

       
        public static bool DeleteWord(int wordId)
        {
            try
            {
                string query = "DELETE FROM Words WHERE WordId = @WordId";

                SqlParameter[] parameters = {
                    new SqlParameter("@WordId", wordId)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    Console.WriteLine("Xóa từ vựng thành công!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Có lỗi xảy ra khi xóa từ vựng.");
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
