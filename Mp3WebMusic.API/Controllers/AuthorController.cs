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
    [ApiController]
    public class AuthorController
    {
        
        private readonly IAuthorService authorService;
        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet]
        [Route("/Api/Author/GetsAuthorIsDelete")]
        public IEnumerable<Author> GetsAuthorIsDelete()
        {
            return authorService.GetsAuthorIsDelete();
        }

        [HttpGet]
        [Route("/Api/Author/GetsAuthorIsNotDelete")]
        public IList<Author> GetsAuthorIsNotDelete()
        {
            return authorService.GetsAuthorIsNotDelete();
        }

        [HttpGet]
        [Route("/Api/Author/GetAuthorById/{id}")]
        public Author GetAuthorById(int id)
        {
            return authorService.GetAuthorById(id);
        }

        [HttpPost]
        [Route("/Api/Author/AddAuthor")]
        public Author AddAuthor(AddAuthor request)
        {
            return authorService.AddAuthor(request);
        }

        [HttpPost]
        [Route("/Api/Author/DeleteAuthor/{id}")]
        public Author DeleteAuthor(int id)
        {
            return authorService.DeleteAuthor(id);
        }
        [HttpPost]
        [Route("/Api/Author/EditAuthor")]
        public Author EditAuthor(EditAuthor request)
        {
            return authorService.EditAuthor(request);
        }
        [HttpPost]
        [Route("/Api/Author/RestoreAuthor/{id}")]
        public Author RestoreAuthor(int id)
        {
            return authorService.RestoreAuthor(id);
        }


    }
}

