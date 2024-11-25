using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace windowforms_sqlsever
{
    internal class WordQuiz
    {
       
        public int WordQuizId { get; set; }  
        public int QuizId { get; set; }      
        public int WordId { get; set; }      

       
        public static bool AddWordToQuiz(int quizId, int wordId)
        {
            string query = "INSERT INTO WordQuiz (QuizId, WordId) VALUES (@QuizId, @WordId)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@QuizId", quizId),
                new SqlParameter("@WordId", wordId)
            };

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0; 
        }

        
        public static bool RemoveWordFromQuiz(int quizId, int wordId)
        {
            string query = "DELETE FROM WordQuiz WHERE QuizId = @QuizId AND WordId = @WordId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@QuizId", quizId),
                new SqlParameter("@WordId", wordId)
            };

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0; 
        }

       
        public static List<WordQuiz> GetWordsForQuiz(int quizId)
        {
            string query = "SELECT * FROM WordQuiz WHERE QuizId = @QuizId";
            SqlParameter[] parameters = { new SqlParameter("@QuizId", quizId) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

           
            List<WordQuiz> wordQuizzes = new List<WordQuiz>();

            foreach (DataRow row in dt.Rows)
            {
                wordQuizzes.Add(new WordQuiz
                {
                    WordQuizId = Convert.ToInt32(row["WordQuizId"]),
                    QuizId = Convert.ToInt32(row["QuizId"]),
                    WordId = Convert.ToInt32(row["WordId"])
                });
            }

            return wordQuizzes;
        }
    }
}
