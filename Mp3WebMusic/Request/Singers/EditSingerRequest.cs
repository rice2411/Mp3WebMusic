﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Reponse.Singers
{
    public class EditSingerRequest
    {
        public int SingerID { get; set; }
        public string SingerNickName { get; set; }
        public string SingerName { get; set; }
        public string Introduce { get; set; }
     
        public string Avatar { get; set; }
      
    }
}