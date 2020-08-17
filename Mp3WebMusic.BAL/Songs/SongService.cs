using Mp3WebMusic.BAL.INTERFACE.Songs;
using Mp3WebMusic.DAL.INTERFACE.Songs;
using Mp3WebMusic.DOMAIN.Request.Songs;
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

        public IList<Song> GetsSongTrending()
        {
            return songRepository.GetsSongTrending();
        }
        public IList<Song> GetsSongIsDelete()
        {
            return songRepository.GetsSongIsDelete();
        }
        public IList<Song> GetsSongByUpLoadday()
        {
            return songRepository.GetsSongByUpLoadday();
        }
        public IList<Song> GetsSongByUpLoaddayTop4()
        {
            return songRepository.GetsSongByUpLoaddayTop4();
        }
        public IList<Song> GetsSongByType(int typeid)
        {
            return songRepository.GetsSongByType( typeid);
        }
        public IList<Song> GetsSongByTopic(int topicid)
        {
            return songRepository.GetsSongByTopic(topicid);
        }
        
        public IList<Song> GetsSongBySinger(int singerid)
        {
            return songRepository.GetsSongBySinger(singerid);
        }

        public IList<Song> GetsSongByAuthor(int authorid)
        {
            return songRepository.GetsSongByAuthor(authorid);
        }

        public Song GetSongById(int songid)
        {
            return songRepository.GetSongById(songid);
        }

        public Song AddSong(Song request)
        {
            return songRepository.AddSong(request);
        }
        public Song DeleteSong(int id )
        {
            return songRepository.DeleteSong(id);
        }
        public Song EditSong(Song request)
        {
            return songRepository.EditSong(request);
        }
        public Song RestoreSong(int id)
        {
            return songRepository.RestoreSong(id);
        }
    }
}
