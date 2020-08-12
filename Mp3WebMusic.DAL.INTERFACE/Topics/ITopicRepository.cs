using Mp3WebMusic.DOMAIN.Request.Topics;
using System.Collections.Generic;
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
        Task<Topic> Add(Topic request);
        Task<Topic> Edit(Topic request);

    }
}
