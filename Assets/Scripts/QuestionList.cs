using System;
using System.Collections;
using System.Collections.Generic;

namespace DefaultNamespace
{
    [Serializable]
    public class QuestionList
    {
        public List<Question> questions;

        public QuestionList(List<Question> questions)
        {
            this.questions = questions;
        }

        public QuestionList()
        {
        }

        public List<Question> Questions
        {
            get { return questions; }
            set { questions = value; }
        }
    }
}