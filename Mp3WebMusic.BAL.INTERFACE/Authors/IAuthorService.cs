using Mp3WebMusic.DOMAIN.Reponse;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL.INTERFACE.Songs
{
    public interface IAuthorService
    {
        IList<Author> GetsAuthorIsDelete();
        //IList<AuthorResult> GetsAuthorByUpLoadday();
        //IList<AuthorResult> GetsAuthorByType(int typeid);
        //IList<AuthorResult> GetsAuthorByTopic(int topicid);
        //IList<AuthorResult> GetsAuthorBySinger(int singerid);
        IList<Author> GetsAuthorIsNotDelete();
        Author GetAuthorById(int authorid);
        Author AddAuthor(AddAuthor request);
        Author DeleteAuthor(int request);
        Author EditAuthor(EditAuthor request);
        Author RestoreAuthor(int request);
    }
}
