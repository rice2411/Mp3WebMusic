using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Reponse
{
    public class Song
    {
        public int SongID { get; set; }
        public string SongName { get; set; }
        public string Audio { get; set; }
        public string Poster { get; set; }
        public int TypeID { get; set; }
        public int TopicID { get; set; }
        public bool IsDelete { get; set; }
        public DateTime UpLoadDate { get; set; }
        public float Views { get; set; }
    }
}
