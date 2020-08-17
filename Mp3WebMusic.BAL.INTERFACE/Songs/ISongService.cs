using Mp3WebMusic.DOMAIN.Request.Songs;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL.INTERFACE.Songs
{
    public interface ISongService
    {
        IList<Song> GetsSongTrending();
        IList<Song> GetsSongIsDelete();
        IList<Song> GetsSongByUpLoadday();
        IList<Song> GetsSongByUpLoaddayTop4();
        IList<Song> GetsSongByType(int typeid);
        IList<Song> GetsSongByTopic(int topicid);
        IList<Song> GetsSongBySinger(int singerid);
        IList<Song> GetsSongByAuthor(int authorid);
        Song GetSongById(int songid);
        Song AddSong(Song request);
        Song DeleteSong(int id );
        Song EditSong(Song request);
        Song RestoreSong(int id);
    }
}
