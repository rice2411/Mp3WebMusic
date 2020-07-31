using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Request.Songs
{
    public class AddSong
    {
        public string SongName { get; set; }
        public string Audio { get; set; }
        public string Poster { get; set; }
        public int TypeID { get; set; }
        public int TopicID { get; set; }
        public string SingerNickName { get; set; }
        public string AuthorName { get; set; }

    }
}
