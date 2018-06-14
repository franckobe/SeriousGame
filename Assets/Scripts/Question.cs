using System;
using System.Collections.Generic;

namespace DefaultNamespace
{
    [Serializable]
    public class Question
    {
        public string label;
        public List<Response> responses;

        public Question()
        {
            
        }

        public Question(string label, List<Response> responses)
        {
            this.label = label;
            this.responses = responses;
        }
    }
}