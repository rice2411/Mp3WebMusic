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
        [Route("/Api/Song/GetsSongByType")]
        public IEnumerable<SongResult> GetsSongByType(int typeid)
        {
            return songService.GetsSongByType(typeid);
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongByTopic")]
        public IEnumerable<SongResult> GetsSongByTopic(int topicid)
        {
            return songService.GetsSongByTopic(topicid);
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongBySinger")]
        public IEnumerable<SongResult> GetsSongBySinger(int singerid)
        {
            return songService.GetsSongBySinger(singerid);
        }
        [HttpGet]
        [Route("/Api/Song/GetsSongByAuthor")]
        public IList<SongResult> GetsSongByAuthor(int authorid)
        {
            return songService.GetsSongByAuthor(authorid);
        }
       
        [HttpGet]
        [Route("/Api/Song/GetSongById")]
        public SongResultById GetSongById(int songid)
        {
            return songService.GetSongById(songid);
        }
        [HttpPost]
        [Route("/Api/Song/AddSong")]
        public Messages AddSong(AddSong request)
        {
            return songService.AddSong(request);
        }
        [HttpPost]
        [Route("/Api/Song/DeleteSong")]
        public Messages DeleteSong(DeleteSong request)
        {
            return songService.DeleteSong(request);
        }
        [HttpPost]
        [Route("/Api/Song/EditSong")]
        public Messages EditSong(EditSong request)
        {
            return songService.EditSong(request);
        }
        [HttpPost]
        [Route("/Api/Song/RestoreSong")]
        public Messages RestoreSong(RestoreSong request)
        {
            return songService.RestoreSong(request);
        }
        #endregion

    }
}
