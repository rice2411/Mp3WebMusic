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
    public class SongRepository : BaseRepository, ISongRepository
    {
        public IList<SongResult> GetsSongTrending()
        {
            IList<SongResult> songs = SqlMapper.Query<SongResult>(connection, "SongGetsTrending", commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }
        public IList<SongResult> GetsSongIsDelete()
        {
            IList<SongResult> songs = SqlMapper.Query<SongResult>(connection, "SongGetsIsDelete", commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }
        public IList<SongResult> GetsSongByUpLoadday()
        {
            IList<SongResult> songs = SqlMapper.Query<SongResult>(connection, "SongGetsByUpLoadDay", commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }
        public IList<SongResult> GetsSongByType(int typeid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TypeID", typeid);
            IList<SongResult> songs = SqlMapper.Query<SongResult>(connection, "SongGetsByType", parameters, commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }
        public IList<SongResult> GetsSongByTopic(int topicid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TopicID", topicid);
            IList<SongResult> songs = SqlMapper.Query<SongResult>(connection, "SongGetsByTopic", parameters, commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }

        public IList<SongResult> GetsSongBySinger(int singerid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SingerID", singerid);
            IList<SongResult> songs = SqlMapper.Query<SongResult>(connection, "SongGetsBySinger", parameters, commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }

        public IList<SongResult> GetsSongByAuthor(int authorid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@AuthorID", authorid);
            IList<SongResult> songs = SqlMapper.Query<SongResult>(connection, "SongGetsByAuthor", parameters, commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }

        public SongResultById GetSongById(int songid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SongID", songid);
            SongResultById song = SqlMapper.Query<SongResultById>(connection, "SongGetByID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return song;
        }
        public Messages AddSong(AddSong request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SongName", request.SongName);
                parameters.Add("@Audio", request.Audio);
                parameters.Add("@Poster", request.Poster);
                parameters.Add("@TypeID", request.TypeID);
                parameters.Add("@TopicID", request.TopicID);
                parameters.Add("@SingerNickName", request.SingerNickName);
                parameters.Add("@AuthorName", request.AuthorName);
                var model = SqlMapper.QueryFirstOrDefault<Messages>(connection, "SongAdd", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Messages()
                {
                    Message = e.Message
                };
            }
        }
        public Messages DeleteSong(int  id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SongID", id);
                var model = SqlMapper.QueryFirstOrDefault<Messages>(connection, "SongDelete", parameters, commandType: CommandType.StoredProcedure);
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
        public Messages EditSong(EditSong request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SongID", request.SongID);
                parameters.Add("@SongName", request.SongName);
                parameters.Add("@Audio", request.Audio);
                parameters.Add("@Poster", request.Poster);
                parameters.Add("@TypeID", request.TypeID);
                parameters.Add("@TopicID", request.TopicID);
                parameters.Add("@SingerNickName", request.SingerNickName);
                parameters.Add("@AuthorName", request.AuthorName);
                var model = SqlMapper.QueryFirstOrDefault<Messages>(connection, "SongEdit", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Messages()
                {
                    Message = e.Message
                };
            }
        }
        public Messages RestoreSong(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SongID", id);
                var model = SqlMapper.QueryFirstOrDefault<Messages>(connection, "SongRestore", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Messages()
                {
                    Message = e.Message
                };
            }
        }
    }
   
}
