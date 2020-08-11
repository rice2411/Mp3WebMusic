using Mp3WebMusic.BAL.INTERFACE;
using Mp3WebMusic.BAL.INTERFACE.Songs;
using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DAL.INTERFACE.Songs;
using Mp3WebMusic.DOMAIN.Reponse;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL.Songs
{
    public class SongService : ISongService
    {
        private ISongRepository songRepository;
        public SongService(ISongRepository songRepository)
        {
            this.songRepository = songRepository;
        }

        public IList<SongResult> GetsSongTrending()
        {
            return songRepository.GetsSongTrending();
        }
        public IList<SongResult> GetsSongIsDelete()
        {
            return songRepository.GetsSongIsDelete();
        }
        public IList<SongResult> GetsSongByUpLoadday()
        {
            return songRepository.GetsSongByUpLoadday();
        }
        public IList<SongResult> GetsSongByType(int typeid)
        {
            return songRepository.GetsSongByType( typeid);
        }
        public IList<SongResult> GetsSongByTopic(int topicid)
        {
            return songRepository.GetsSongByTopic(topicid);
        }
        
        public IList<SongResult> GetsSongBySinger(int singerid)
        {
            return songRepository.GetsSongBySinger(singerid);
        }

        public IList<SongResult> GetsSongByAuthor(int authorid)
        {
            return songRepository.GetsSongByAuthor(authorid);
        }

        public SongResultById GetSongById(int songid)
        {
            return songRepository.GetSongById(songid);
        }

        public Messages AddSong(AddSong request)
        {
            return songRepository.AddSong(request);
        }
        public Messages DeleteSong(int id )
        {
            return songRepository.DeleteSong(id);
        }
        public Messages EditSong(EditSong request)
        {
            return songRepository.EditSong(request);
        }
        public Messages RestoreSong(int id)
        {
            return songRepository.RestoreSong(id);
        }
    }
}
