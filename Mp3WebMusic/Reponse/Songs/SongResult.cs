using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Reponse.Songs
{
    public class SongResult
    {
        public int SongID { get; set; }
        public int SingerID { get; set; }
        public string SongName { get; set; }
        public string Poster { get; set; }
        public string SingerNickName { get; set; }
    }
}
