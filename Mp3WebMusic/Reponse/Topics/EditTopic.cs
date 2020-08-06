using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Reponse.Topics
{
    public class EditTopic
    {
        public int TopicID { get; set; }
        public string TopicName { get; set; }
        public string Message { get; set; }
    }
}
