using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Request.Songs
{
    public class AddAuthor
    {        
        public string AuthorName { get; set; }
        public string Avatar { get; set; }        
        public string Introduce { get; set; }       

    }
}
