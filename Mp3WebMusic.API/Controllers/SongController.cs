using Microsoft.AspNetCore.Mvc;
using Mp3WebMusic.BAL.INTERFACE;
using Mp3WebMusic.BAL.INTERFACE.Songs;
using Mp3WebMusic.DOMAIN.Reponse;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IEnumerable<SongResult> GetsSongTrending()
        {
            return songService.GetsSongTrending();
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongIsDelete")]
        public IEnumerable<SongResult> GetsSongIsDelete()
        {
            return songService.GetsSongIsDelete();
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongByUpLoadday")]
        public IEnumerable<SongResult> GetsSongByUpLoadday()
        {
            return songService.GetsSongByUpLoadday();
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongByType/{id}")]
        public IEnumerable<SongResult> GetsSongByType(int id)
        {
            return songService.GetsSongByType(id);
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongByTopic/{id}")]
        public IEnumerable<SongResult> GetsSongByTopic(int id)
        {
            return songService.GetsSongByTopic(id);
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongBySinger/{id}")]
        public IEnumerable<SongResult> GetsSongBySinger(int id)
        {
            return songService.GetsSongBySinger(id);
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongByAuthor/{id}")]
        public IList<SongResult> GetsSongByAuthor(int id)
        {
            return songService.GetsSongByAuthor(id);
        }
       
        [HttpGet]
        [Route("/Api/Song/GetSongById/{id}")]
        public SongResultById GetSongById(int id)
        {
            return songService.GetSongById(id);
        }
        [HttpPost]
        [Route("/Api/Song/AddSong")]
        public Messages AddSong(AddSong request)
        {
            return songService.AddSong(request);
        }
        [HttpPost]
        [Route("/Api/Song/DeleteSong/{id}")]
        public Messages DeleteSong(int id )
        {
            return songService.DeleteSong(id);
        }
        [HttpPost]
        [Route("/Api/Song/EditSong")]
        public Messages EditSong(EditSong request)
        {
            return songService.EditSong(request);
        }
        [HttpPost]
        [Route("/Api/Song/RestoreSong/{id}")]
        public Messages RestoreSong(int id)
        {
            return songService.RestoreSong(id);
        }
        #endregion

    }
}
