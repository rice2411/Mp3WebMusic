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
        Task<IList<Topic>> GetsTopicIsNotDelete();
        Task<IList<Topic>> GetsTopicIsDelete();
      
        Task<Topic> Get(int TopicID); 
        Task<Topic> Delete(int id);
        Task<Topic> Restore(int id);
        Task<Topic> Add( AddTopicRequest request);
        Task<Topic> Edit(EditTopicRequest request);

    }
}
