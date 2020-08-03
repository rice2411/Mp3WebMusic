using Mp3WebMusic.DOMAIN.Reponse;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL.INTERFACE.Songs
{
    public interface IAuthorService
    {
        IList<AuthorResult> GetsAuthorIsDelete();
        //IList<AuthorResult> GetsAuthorByUpLoadday();
        //IList<AuthorResult> GetsAuthorByType(int typeid);
        //IList<AuthorResult> GetsAuthorByTopic(int topicid);
        //IList<AuthorResult> GetsAuthorBySinger(int singerid);
        IList<AuthorResult> GetsAuthorIsNotDelete();
        AuthorResultById GetAuthorById(int authorid);
        Messages AddAuthor(AddAuthor request);
        Messages DeleteAuthor(DeleteAuthor request);
        Messages EditAuthor(EditAuthor request);
        Messages RestoreAuthor(RestoreAuthor request);
    }
}
