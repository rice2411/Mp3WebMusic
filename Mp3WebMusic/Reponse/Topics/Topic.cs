using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Reponse.Topics
{
    public class Topic
    {
        public int TopicID { get; set; }
        public string TopicName { get; set; }
        public bool IsDelete { get; set; }
        public string Message { get; set; }
    }
}
