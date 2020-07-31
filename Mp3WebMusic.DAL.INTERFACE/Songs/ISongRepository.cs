using Mp3WebMusic.DOMAIN.Reponse;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DAL.INTERFACE.Songs
{
    public interface ISongRepository
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
        Messages DeleteSong(DeleteSong request);
        Messages EditSong(EditSong request);
        Messages RestoreSong(RestoreSong request);
    }
}
