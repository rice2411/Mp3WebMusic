using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Request.Singers
{
   public class Singer
    {
        public int SingerID { get; set; }
        public string SingerNickName { get; set; }
        public string SingerName { get; set; }
        public string Introduce { get; set; }
        public int Views { get; set; }
        public string Avatar { get; set; }
        public string Message { get; set; }
        public bool isDelete { get; set; }

    }
}
