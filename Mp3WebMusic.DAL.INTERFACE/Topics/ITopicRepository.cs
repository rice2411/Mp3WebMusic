using Mp3WebMusic.DOMAIN.Reponse;
using Mp3WebMusic.DOMAIN.Reponse.Topics;
using Mp3WebMusic.DOMAIN.Request.Topics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mp3WebMusic.DAL.INTERFACE
{
    public interface ITopicRepository
    {
        Task<IList<GetTopic>> GetsTopicIsNotDelete();
        Task<IList<GetTopic>> GetsTopicIsDelete();
      
        Task<GetTopic> Get(int TopicID); 
        Task<DeleteTopic> Delete(DeleteTopicRequest request);
        Task<DeleteTopic> Restore(DeleteTopicRequest request);
        Task<AddTopic> Add( AddTopicRequest request);
        Task<EditTopic> Edit(EditTopicRequest request);

    }
}
