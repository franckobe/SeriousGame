using System;
using UnityEngine.UI;

namespace DefaultNamespace
{
    [Serializable]
    public class Response
    {
        public string label;
        public int point;

        public Response(string label, int point)
        {
            this.label = label;
            this.point = point;
        }
    }
}