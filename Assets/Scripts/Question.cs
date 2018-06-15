using System;
using System.Collections.Generic;

namespace DefaultNamespace
{
    [Serializable]
    public class Question
    {
        public string label;
        public List<Response> responses;
        public string ordre;

        public Question()
        {
            
        }

        public Question(string label, List<Response> responses, string ordre)
        {
            this.label = label;
            this.responses = responses;
            this.ordre = ordre;
        }
    }
}