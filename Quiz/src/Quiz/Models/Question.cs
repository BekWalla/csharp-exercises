using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class Question
    {
        public string Ask { get; set; }
        public string Answers { get; set; }
        public string CorrectAnswer { get; set; }


        public Question(string ask, string answers, string correctAnswer)
        {
            Ask = ask;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }
public bool QuestionCorrect(string userInput, string correctAnswer)
        {
            if(userInput.Equals(correctAnswer))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
