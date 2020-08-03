using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Reponse.Songs
{
    public class AuthorResultById
    {       
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public string Introduce { get; set; }
        public string Avatar { get; set; }        
        
    }
}
