using Mp3WebMusic.BAL.INTERFACE.Topics;
using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DOMAIN.Request.Topics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mp3WebMusic.BAL.Topics
{
    public class TopicService: ITopicService
    {
        private ITopicRepository topicRepository;
        public TopicService(ITopicRepository topicRepository)
        {
            this.topicRepository = topicRepository;
        }

      

        public async Task<IList<Topic>> GetsTopicIsDelete()
        {
            return await topicRepository.GetsTopicIsDelete();
        }

        public async Task<Topic> Get(int TopicID)
        {
            return await topicRepository.Get(TopicID);
        }

        public async Task<Topic> Delete(int request)
        {
            return await topicRepository.Delete(request);
        }

        public async Task<Topic> Add(Topic request)
        {
            return await topicRepository.Add(request);
        }

        public  async Task<Topic> Edit(Topic request)
        {
            return await topicRepository.Edit(request);
        }

       

        public async Task<IList<Topic>> GetsTopicIsNotDelete()
        {
            return await topicRepository.GetsTopicIsNotDelete();
        }

        public async Task<Topic> Restore(int request)
        {
            return await topicRepository.Restore(request);
        }
    }
}
