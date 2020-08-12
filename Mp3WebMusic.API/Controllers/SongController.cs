using Microsoft.AspNetCore.Mvc;
using Mp3WebMusic.BAL.INTERFACE.Songs;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System.Collections.Generic;

namespace Mp3WebMusic.API.Controllers
{
    [ApiController]
    public class SongController : Controller
    {
        private readonly ISongService songService;
        public SongController(ISongService songService)
        {
            this.songService = songService;
        }
        #region Song
        [HttpGet]
        [Route("/Api/Song/GetsSongTrending")]
        public IEnumerable<Song> GetsSongTrending()
        {
            return songService.GetsSongTrending();
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongIsDelete")]
        public IEnumerable<Song> GetsSongIsDelete()
        {
            return songService.GetsSongIsDelete();
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongByUpLoadday")]
        public IEnumerable<Song> GetsSongByUpLoadday()
        {
            return songService.GetsSongByUpLoadday();
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongByType/{id}")]
        public IEnumerable<Song> GetsSongByType(int id)
        {
            return songService.GetsSongByType(id);
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongByTopic/{id}")]
        public IEnumerable<Song> GetsSongByTopic(int id)
        {
            return songService.GetsSongByTopic(id);
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongBySinger/{id}")]
        public IEnumerable<Song> GetsSongBySinger(int id)
        {
            return songService.GetsSongBySinger(id);
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongByAuthor/{id}")]
        public IList<Song> GetsSongByAuthor(int id)
        {
            return songService.GetsSongByAuthor(id);
        }
       
        [HttpGet]
        [Route("/Api/Song/GetSongById/{id}")]
        public Song GetSongById(int id)
        {
            return songService.GetSongById(id);
        }
        [HttpPost]
        [Route("/Api/Song/AddSong")]
        public Song AddSong(Song request)
        {
            return songService.AddSong(request);
        }
        [HttpPost]
        [Route("/Api/Song/DeleteSong/{id}")]
        public Song DeleteSong(int id )
        {
            return songService.DeleteSong(id);
        }
        [HttpPost]
        [Route("/Api/Song/EditSong")]
        public Song EditSong(Song request)
        {
            return songService.EditSong(request);
        }
        [HttpPost]
        [Route("/Api/Song/RestoreSong/{id}")]
        public Song RestoreSong(int id)
        {
            return songService.RestoreSong(id);
        }
        #endregion

    }
}
