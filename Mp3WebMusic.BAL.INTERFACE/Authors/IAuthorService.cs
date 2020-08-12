using Mp3WebMusic.DOMAIN.Reponse.Songs;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL.INTERFACE.Songs
{
    public interface IAuthorService
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
