using Mp3WebMusic.DOMAIN.Reponse.Songs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Request.Songs
{
    public class EditAuthor
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Avatar { get; set; }
        public string Introduce { get; set; }
        public DateTime UpLoadDate { get; set; }
    }
}
