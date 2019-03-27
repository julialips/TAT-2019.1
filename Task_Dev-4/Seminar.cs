using System.Collections.Generic;

namespace Task_Dev_4
{
    /// <summary>
    /// on class of discipline
    /// </summary>
    class Seminar : IDandDescribe
    {
        List<string> task;
        List<string> questions;
        List<string> answers;

        /// <summary>
        /// 
        /// </summary>
        public Seminar() : base()
        {
            task = new List<string>();
            questions = new List<string>();
            answers = new List<string>();
            //Add tasks, questions and answer the questions to list.
            for (int i = 0; i < random.Next(1, 15); i++)
            {
                task.Add(WriteText(30));
            }
            //Number of questions and answer the questions equals.
            for (int i = 0; i < random.Next(1, 15); i++)
            {
                questions.Add(WriteText(20));
                answers.Add(WriteText(30));
            }
        }
    }
}

   