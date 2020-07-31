using Mp3WebMusic.DOMAIN.Reponse.Songs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Request.Songs
{
    public class EditSong : AddSong
    {
        public int SongID { get; set; }
    }
}
