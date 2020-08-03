using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Reponse.Singers
{
   public class AddSinger
    {
        public string SingerNickName { get; set; }
        public string SingerName { get; set; }
        public string Introduce { get; set; }
     
        public string Avatar { get; set; }
        public string Message { get; set; }
    }
}
