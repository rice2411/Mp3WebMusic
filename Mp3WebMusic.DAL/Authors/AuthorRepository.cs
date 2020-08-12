using Dapper;
using Mp3WebMusic.DAL.INTERFACE.Songs;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Mp3WebMusic.DAL.Songs
{
    public class AuthorRepository : BaseRepository, IAuthorRepository
    {

        public IList<Author> GetsAuthorIsDelete()
        {
            IList<Author> authors = SqlMapper.Query<Author>(connection, "AuthorGetsIsDelete", commandType: CommandType.StoredProcedure).ToList();
            return authors;
        }

        public IList<Author> GetsAuthorIsNotDelete()
        {
         
            IList<Author> authors = SqlMapper.Query<Author>(connection, "AuthorGetsIsNotDelete",  commandType: CommandType.StoredProcedure).ToList();
            return authors;
        }
        public Author GetAuthorById(int authorid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@AuthorId", authorid);
            Author author = SqlMapper.Query<Author>(connection, "AuthorGetByID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return author ;
        }
        public Author AddAuthor(Author request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                

                parameters.Add("@AuthorName", request.AuthorName);
                parameters.Add("@Avatar", request.Avatar);
                parameters.Add("@Introduce", request.Introduce);              
                
                
                var model = SqlMapper.QueryFirstOrDefault<Author>(connection, "AuthorAdd", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Author()
                {
                    Message = e.Message
                };
            }
        }
        public Author DeleteAuthor(int request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AuthorId", request);
                var model = SqlMapper.QueryFirstOrDefault<Author>(connection, "AuthorDelete", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Author()
                {
                    Message = e.Message
                };
            }
        }
        public Author EditAuthor(Author request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AuthorId", request.AuthorId);
                parameters.Add("@AuthorName", request.AuthorName);
                parameters.Add("@Avatar", request.Avatar);
                parameters.Add("@Introduce", request.Introduce);
                //parameters.Add("@UpLoadDate", request.UpLoadDate);
                
                var model = SqlMapper.QueryFirstOrDefault<Author>(connection, "AuthorEdit", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Author()
                {
                    Message = e.Message
                };
            }
        }
        public Author RestoreAuthor(int request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AuthorId", request);
                var model = SqlMapper.QueryFirstOrDefault<Author>(connection, "AuthorRestore", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Author()
                {
                    Message = e.Message
                };
            }
        }
    }

}
