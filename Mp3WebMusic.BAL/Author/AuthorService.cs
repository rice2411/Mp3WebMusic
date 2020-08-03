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

        public IList<AuthorResult> GetsAuthorIsDelete()
        {
            return authorRepository.GetsAuthorIsDelete();
        }
        //public IList<AuthorResult> GetsAuthorByUpLoadday()
        //{
        //    return authorRepository.GetsAuthorByUpLoadday();
        //}
        //public IList<SongResult> GetsSongByType(int typeid)
        //{
        //    return songRepository.GetsSongByType( typeid);
        //}
        //public IList<SongResult> GetsSongByTopic(int topicid)
        //{
        //    return songRepository.GetsSongByTopic(topicid);
        //}
        
        //public IList<SongResult> GetsSongBySinger(int singerid)
        //{
        //    return songRepository.GetsSongBySinger(singerid);
        //}

        public IList<AuthorResult> GetsAuthorIsNotDelete()
        {
            return authorRepository.GetsAuthorIsNotDelete();
        }

        public AuthorResultById GetAuthorById(int authorid)
        {
            return authorRepository.GetAuthorById(authorid);
        }

        public Messages AddAuthor(AddAuthor request)
        {
            return authorRepository.AddAuthor(request);
        }
        public Messages DeleteAuthor(DeleteAuthor request)
        {
            return authorRepository.DeleteAuthor(request);
        }
        public Messages EditAuthor(EditAuthor request)
        {
            return authorRepository.EditAuthor(request);
        }
        public Messages RestoreAuthor(RestoreAuthor request)
        {
            return authorRepository.RestoreAuthor(request);
        }
        
    }
}
