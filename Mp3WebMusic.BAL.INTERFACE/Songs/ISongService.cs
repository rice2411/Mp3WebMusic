using Mp3WebMusic.DOMAIN.Reponse;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL.INTERFACE.Songs
{
    public interface ISongService
    {
        IList<Song> GetsSongTrending();
        IList<Song> GetsSongIsDelete();
        IList<Song> GetsSongByUpLoadday();
        IList<Song> GetsSongByType(int typeid);
        IList<Song> GetsSongByTopic(int topicid);
        IList<Song> GetsSongBySinger(int singerid);
        IList<Song> GetsSongByAuthor(int authorid);
        Song GetSongById(int songid);
        Song AddSong(AddSong request);
        Song DeleteSong(int id );
        Song EditSong(EditSong request);
        Song RestoreSong(int id);
    }
}
