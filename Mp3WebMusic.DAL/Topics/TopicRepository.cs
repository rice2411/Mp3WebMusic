using Dapper;
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
        public async Task<AddTopic> Add(AddTopicRequest request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TopicName", request.TopicName);
               
                var model = SqlMapper.QueryFirstOrDefault<AddTopic>(connection, "TopicAdd", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new AddTopic()
                {
                    Message = "Something went wrong, please try again"
                };
            }
        }

        public async Task<DeleteTopic> Delete(DeleteTopicRequest request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TopicID", request.TopicID);

                var model = SqlMapper.QueryFirstOrDefault<DeleteTopic>(connection, "TopicDelete", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new DeleteTopic()
                {
                    Message = "Something went wrong, please try again"
                };
            }

        }

        public async Task<EditTopic> Edit(EditTopicRequest request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TopicName", request.TopicName);
                parameters.Add("@TopicID", request.TopicID);

                var model = SqlMapper.QueryFirstOrDefault<EditTopic>(connection, "TopicEdit", parameters, commandType: CommandType.StoredProcedure);
                return  model;
            }
            catch (Exception e)
            {
                return new EditTopic()
                {
                    Message = "Something went wrong, please try again"
                };
            }

        }

        public async Task<GetTopic> Get(int TopicID)
        {

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TopicID", TopicID);
            return (await SqlMapper.QueryFirstOrDefaultAsync<GetTopic>(cnn: connection,
                             param: parameters,
                            sql: "TopicGetByID",
                            commandType: CommandType.StoredProcedure));
        }

       public async Task<IList<GetTopic>> GetsTopicIsDelete()
        {
            IList<GetTopic> topics = SqlMapper.Query<GetTopic>(connection, "TopicGetsIsDelete", commandType: CommandType.StoredProcedure).ToList();
              return  topics;
        }

        public async Task<IList<GetTopic>> GetsTopicIsNotDelete()
        {
            IList<GetTopic> topics = SqlMapper.Query<GetTopic>(connection, "TopicGetsIsNotDelete", commandType: CommandType.StoredProcedure).ToList();
            return topics;
        }

        public async Task<DeleteTopic> Restore(DeleteTopicRequest request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TopicID", request.TopicID);

                var model = SqlMapper.QueryFirstOrDefault<DeleteTopic>(connection, "TopicRestore", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new DeleteTopic()
                {
                    Message = "Something went wrong, please try again"
                };
            }
        }
    }
}
