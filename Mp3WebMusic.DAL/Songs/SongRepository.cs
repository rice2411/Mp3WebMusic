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
        public IList<Song> GetsSongTrending()
        {
            IList<Song> songs = SqlMapper.Query<Song>(connection, "SongGetsTrending", commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }
        public IList<Song> GetsSongIsDelete()
        {
            IList<Song> songs = SqlMapper.Query<Song>(connection, "SongGetsIsDelete", commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }
        public IList<Song> GetsSongByUpLoadday()
        {
            IList<Song> songs = SqlMapper.Query<Song>(connection, "SongGetsByUpLoadDay", commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }
        public IList<Song> GetsSongByType(int typeid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TypeID", typeid);
            IList<Song> songs = SqlMapper.Query<Song>(connection, "SongGetsByType", parameters, commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }
        public IList<Song> GetsSongByTopic(int topicid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TopicID", topicid);
            IList<Song> songs = SqlMapper.Query<Song>(connection, "SongGetsByTopic", parameters, commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }

        public IList<Song> GetsSongBySinger(int singerid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SingerID", singerid);
            IList<Song> songs = SqlMapper.Query<Song>(connection, "SongGetsBySinger", parameters, commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }

        public IList<Song> GetsSongByAuthor(int authorid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@AuthorID", authorid);
            IList<Song> songs = SqlMapper.Query<Song>(connection, "SongGetsByAuthor", parameters, commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }

        public Song GetSongById(int songid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SongID", songid);
            Song song = SqlMapper.Query<Song>(connection, "SongGetByID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return song;
        }
        public Song AddSong(AddSong request)
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
                var model = SqlMapper.QueryFirstOrDefault<Song>(connection, "SongAdd", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Song()
                {
                    Message = e.Message
                };
            }
        }
        public Song DeleteSong(int  id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SongID", id);
                var model = SqlMapper.QueryFirstOrDefault<Song>(connection, "SongDelete", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Song()
                {
                    Message = "Something went wrong"
                };
            }
        }
        public Song EditSong(EditSong request)
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
                var model = SqlMapper.QueryFirstOrDefault<Song>(connection, "SongEdit", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Song()
                {
                    Message = e.Message
                };
            }
        }
        public Song RestoreSong(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SongID", id);
                var model = SqlMapper.QueryFirstOrDefault<Song>(connection, "SongRestore", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Song()
                {
                    Message = e.Message
                };
            }
        }
    }
   
}
