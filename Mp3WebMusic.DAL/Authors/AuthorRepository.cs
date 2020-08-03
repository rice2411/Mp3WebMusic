using Dapper;
using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DAL.INTERFACE.Songs;
using Mp3WebMusic.DOMAIN.Reponse;
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
        //public IList<AuthorResult> GetsSongTrending()
        //{
        //    IList<SongResult> songs = SqlMapper.Query<SongResult>(connection, "SongGetsTrending", commandType: CommandType.StoredProcedure).ToList();
        //    return songs;
        //}
        public IList<AuthorResult> GetsAuthorIsDelete()
        {
            IList<AuthorResult> authors = SqlMapper.Query<AuthorResult>(connection, "AuthorGetsIsDelete", commandType: CommandType.StoredProcedure).ToList();
            return authors;
        }
        //public IList<AuthorResult> GetsAuthorByUpLoadday()
        //{
        //    IList<AuthorResult> authors = SqlMapper.Query<AuthorResult>(connection, "AuthorGetsByUpLoadDay", commandType: CommandType.StoredProcedure).ToList();
        //    return authors;
        //}
        //public IList<AuthorResult> GetsAuthorByType(int typeid)
        //{
        //    DynamicParameters parameters = new DynamicParameters();
        //    parameters.Add("@TypeID", typeid);
        //    IList<SongResult> songs = SqlMapper.Query<SongResult>(connection, "SongGetsByType", parameters, commandType: CommandType.StoredProcedure).ToList();
        //    return songs;
        //}
        //public IList<SongResult> GetsSongByTopic(int topicid)
        //{
        //    DynamicParameters parameters = new DynamicParameters();
        //    parameters.Add("@TopicID", topicid);
        //    IList<SongResult> songs = SqlMapper.Query<SongResult>(connection, "SongGetsByTopic", parameters, commandType: CommandType.StoredProcedure).ToList();
        //    return songs;
        //}

        //public IList<SongResult> GetsSongBySinger(int singerid)
        //{
        //    DynamicParameters parameters = new DynamicParameters();
        //    parameters.Add("@SingerID", singerid);
        //    IList<SongResult> songs = SqlMapper.Query<SongResult>(connection, "SongGetsBySinger", parameters, commandType: CommandType.StoredProcedure).ToList();
        //    return songs;
        //}

        public IList<AuthorResult> GetsByAuthor(int authorid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@AuthorID", authorid);
            IList<AuthorResult> authors = SqlMapper.Query<AuthorResult>(connection, "AuthorGetsByAuthor", parameters, commandType: CommandType.StoredProcedure).ToList();
            return authors;
        }
        public AuthorResultById GetAuthorById(int authorid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@AuthorId", authorid);
            AuthorResultById author = SqlMapper.Query<AuthorResultById>(connection, "AuthorGetByID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return author ;
        }
        public Messages AddAuthor(AddAuthor request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                

                parameters.Add("@AuthorName", request.AuthorName);
                parameters.Add("@Avatar", request.Avatar);
                parameters.Add("@Introduce", request.Introduce);              
                
                
                var model = SqlMapper.QueryFirstOrDefault<Messages>(connection, "AuthorAdd", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Messages()
                {
                    Message = "Something went wrong"
                };
            }
        }
        public Messages DeleteAuthor(DeleteAuthor request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AuthorId", request.AuthorId);
                var model = SqlMapper.QueryFirstOrDefault<Messages>(connection, "AuthorDelete", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Messages()
                {
                    Message = "Something went wrong"
                };
            }
        }
        public Messages EditAuthor(EditAuthor request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AuthorId", request.AuthorId);
                parameters.Add("@AuthorName", request.AuthorName);
                parameters.Add("@Avatar", request.Avatar);
                parameters.Add("@Introduce", request.Introduce);
                //parameters.Add("@UpLoadDate", request.UpLoadDate);
                
                var model = SqlMapper.QueryFirstOrDefault<Messages>(connection, "AuthorEdit", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Messages()
                {
                    Message = "Something went wrong"
                };
            }
        }
        public Messages RestoreAuthor(RestoreAuthor request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AuthorId", request.AuthorId);
                var model = SqlMapper.QueryFirstOrDefault<Messages>(connection, "AuthorRestore", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Messages()
                {
                    Message = "Something went wrong"
                };
            }
        }
    }

}
