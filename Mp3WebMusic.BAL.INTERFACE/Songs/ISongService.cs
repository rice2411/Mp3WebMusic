using Mp3WebMusic.DOMAIN.Reponse;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL.INTERFACE.Songs
{
    public interface ISongService
    {
        IList<SongResult> GetsSongTrending();
        IList<SongResult> GetsSongIsDelete();
        IList<SongResult> GetsSongByUpLoadday();
        IList<SongResult> GetsSongByType(int typeid);
        IList<SongResult> GetsSongByTopic(int topicid);
        IList<SongResult> GetsSongBySinger(int singerid);
        IList<SongResult> GetsSongByAuthor(int authorid);
        SongResultById GetSongById(int songid);
        Messages AddSong(AddSong request);
        Messages DeleteSong(int id );
        Messages EditSong(EditSong request);
        Messages RestoreSong(int id);
    }
}
