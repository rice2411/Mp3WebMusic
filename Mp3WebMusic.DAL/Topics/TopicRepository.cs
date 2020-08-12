﻿using Dapper;
using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DOMAIN.Reponse.Topics;
using Mp3WebMusic.DOMAIN.Request.Topics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mp3WebMusic.DAL.Topics
{
    public class TopicRepository : BaseRepository, ITopicRepository

    {
        public async Task<Topic> Add(AddTopicRequest request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TopicName", request.TopicName);
               
                var model = SqlMapper.QueryFirstOrDefault<Topic>(connection, "TopicAdd", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Topic()
                {
                    Message = e.Message
                };
            }
        }

        public async Task<Topic> Delete(int request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TopicID", request);

                var model = SqlMapper.QueryFirstOrDefault<Topic>(connection, "TopicDelete", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Topic()
                {
                    Message = e.Message
                };
            }

        }

        public async Task<Topic> Edit(EditTopicRequest request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TopicName", request.TopicName);
                parameters.Add("@TopicID", request.TopicID);

                var model = SqlMapper.QueryFirstOrDefault<Topic>(connection, "TopicEdit", parameters, commandType: CommandType.StoredProcedure);
                return  model;
            }
            catch (Exception e)
            {
                return new Topic()
                {
                    Message = e.Message
                };
            }

        }

        public async Task<Topic> Get(int TopicID)
        {

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TopicID", TopicID);
            return (await SqlMapper.QueryFirstOrDefaultAsync<Topic>(cnn: connection,
                             param: parameters,
                            sql: "TopicGetByID",
                            commandType: CommandType.StoredProcedure));
        }

       public async Task<IList<Topic>> GetsTopicIsDelete()
        {
            IList<Topic> topics = SqlMapper.Query<Topic>(connection, "TopicGetsIsDelete", commandType: CommandType.StoredProcedure).ToList();
              return  topics;
        }

        public async Task<IList<Topic>> GetsTopicIsNotDelete()
        {
            IList<Topic> topics = SqlMapper.Query<Topic>(connection, "TopicGetsIsNotDelete", commandType: CommandType.StoredProcedure).ToList();
            return topics;
        }

        public async Task<Topic> Restore(int request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TopicID", request);

                var model = SqlMapper.QueryFirstOrDefault<Topic>(connection, "TopicRestore", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Topic()
                {
                    Message = e.Message
                };
            }
        }
    }
}
