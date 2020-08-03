using Microsoft.AspNetCore.Mvc;
using Mp3WebMusic.BAL.INTERFACE.Songs;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mp3WebMusic.API.Controllers
{
    public class AuthorController
    {
        
        private readonly IAuthorService authorService;
        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }
        //[HttpGet]
        //[Route("/Api/Author/GetsSongTrending")]
        //public IEnumerable<SongResult> GetsSongTrending()
        //{
        //    return songService.GetsSongTrending();
        //}
        [HttpGet]
        [Route("/Api/Author/GetsAuthorIsDelete")]
        public IEnumerable<AuthorResult> GetsAuthorIsDelete()
        {
            return authorService.GetsAuthorIsDelete();
        }
        //[HttpGet]
        //[Route("/Api/Author/GetsAuthorByUpLoadday")]
        //public IEnumerable<AuthorResult> GetsByUpLoadday()
        //{
        //    return authorService.GetsAuthorByUpLoadday();
        //}
        //[HttpGet]
        //[Route("/Api/Song/GetsSongByType")]
        //public IEnumerable<SongResult> GetsSongByType(int typeid)
        //{
        //    return songService.GetsSongByType(typeid);
        //}
        //[HttpGet]
        //[Route("/Api/Song/GetsSongByTopic")]
        //public IEnumerable<SongResult> GetsSongByTopic(int topicid)
        //{
        //    return songService.GetsSongByTopic(topicid);
        //}
        //[HttpGet]
        //[Route("/Api/Song/GetsSongBySinger")]
        //public IEnumerable<SongResult> GetsSongBySinger(int singerid)
        //{
        //    return songService.GetsSongBySinger(singerid);
        //}
        [HttpGet]
        [Route("/Api/Author/GetsByAuthor")]
        public IList<AuthorResult> GetsByAuthor(int authorid)
        {
            return authorService.GetsByAuthor(authorid);
        }

        [HttpGet]
        [Route("/Api/Author/GetAuthorById")]
        public AuthorResultById GetAuthorById(int authorid)
        {
            return authorService.GetAuthorById(authorid);
        }

        [HttpPost]
        [Route("/Api/Author/AddAuthor")]
        public Messages AddAuthor(AddAuthor request)
        {
            return authorService.AddAuthor(request);
        }

        [HttpPost]
        [Route("/Api/Author/DeleteAuthor")]
        public Messages DeleteAuthor(DeleteAuthor request)
        {
            return authorService.DeleteAuthor(request);
        }
        [HttpPost]
        [Route("/Api/Author/EditAuthor")]
        public Messages EditAuthor(EditAuthor request)
        {
            return authorService.EditAuthor(request);
        }
        [HttpPost]
        [Route("/Api/Author/RestoreAuthor")]
        public Messages RestoreAuthor(RestoreAuthor request)
        {
            return authorService.RestoreAuthor(request);
        }


    }
}

