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
    public class AuthorService : IAuthorService
    {
        private IAuthorRepository authorRepository;
        public AuthorService(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public IList<Author> GetsAuthorIsDelete()
        {
            return authorRepository.GetsAuthorIsDelete();
        }
      

        public IList<Author> GetsAuthorIsNotDelete()
        {
            return authorRepository.GetsAuthorIsNotDelete();
        }

        public Author GetAuthorById(int authorid)
        {
            return authorRepository.GetAuthorById(authorid);
        }

        public Author AddAuthor(AddAuthor request)
        {
            return authorRepository.AddAuthor(request);
        }
        public Author DeleteAuthor(int request)
        {
            return authorRepository.DeleteAuthor(request);
        }
        public Author EditAuthor(EditAuthor request)
        {
            return authorRepository.EditAuthor(request);
        }
        public Author RestoreAuthor(int request)
        {
            return authorRepository.RestoreAuthor(request);
        }
        
    }
}
