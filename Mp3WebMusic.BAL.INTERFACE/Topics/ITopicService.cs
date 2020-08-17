using Mp3WebMusic.DOMAIN.Request.Topics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mp3WebMusic.BAL.INTERFACE.Topics
{
    public interface ITopicService
    {
        Task<IList<Topic>> GetsTopicIsNotDelete();
        Task<IList<Topic>> GetsTopicIsDelete();
        Task<IList<Topic>> GetsTopicTop4();
        Task<Topic> Get(int TopicID);
        Task<Topic> Delete(int request);
        Task<Topic> Restore(int request);
        Task<Topic> Add(Topic request);
        Task<Topic> Edit(Topic request);

    }
}
