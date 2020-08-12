﻿using Mp3WebMusic.DOMAIN.Reponse;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DAL.INTERFACE.Songs
{
    public interface IAuthorRepository
    {        
        IList<Author> GetsAuthorIsDelete();

        IList<Author> GetsAuthorIsNotDelete();
        Author GetAuthorById(int authorid);
        Author AddAuthor(AddAuthor request);
        Author DeleteAuthor(int request);
        Author EditAuthor(EditAuthor request);
        Author RestoreAuthor(int request);
    }
}
