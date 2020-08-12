using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System.Collections.Generic;

namespace Mp3WebMusic.DAL.INTERFACE.Songs
{
    public interface IAuthorRepository
    {        
        IList<Author> GetsAuthorIsDelete();

        IList<Author> GetsAuthorIsNotDelete();
        Author GetAuthorById(int authorid);
        Author AddAuthor(Author request);
        Author DeleteAuthor(int request);
        Author EditAuthor(Author request);
        Author RestoreAuthor(int request);
    }
}
