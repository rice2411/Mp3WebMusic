using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Reponse.Songs
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Avatar { get; set; }
        public string Introduce { get; set; }        
        public bool IsDelete { get; set; }
        public DateTime UpLoadDate { get; set; }
        public float Views { get; set; }
    }
}
