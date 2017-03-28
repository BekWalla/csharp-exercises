using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class Quiz
    {
        private string name;
        public List<Question> questions;
        public int score;

        public List<Question> Questions
        {
            get { return questions; }
            set { questions = value; }
        }

        private double GradeQuiz(List<Question> Questions)
        {
            int totalOfQuestions = 0;
            foreach(question in Questions)
            {
                if(QuestionCorrect ==true)
                {
                    score++;
                }
                totalOfQuestions++;

             }
            double grade = (score / totalOfQuestions);
            return grade;
        }
    }
}
