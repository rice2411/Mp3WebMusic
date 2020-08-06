using Mp3WebMusic.BAL.INTERFACE.Topics;
using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DOMAIN.Reponse.Topics;
using Mp3WebMusic.DOMAIN.Request.Topics;
using System;
using System.Collections.Generic;
using System.Text;
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

      

        public async Task<IList<GetTopic>> GetsTopicIsDelete()
        {
            return await topicRepository.GetsTopicIsDelete();
        }

        public async Task<GetTopic> Get(int TopicID)
        {
            return await topicRepository.Get(TopicID);
        }

        public async Task<DeleteTopic> Delete(DeleteTopicRequest request)
        {
            return await topicRepository.Delete(request);
        }

        public async Task<AddTopic> Add(AddTopicRequest request)
        {
            return await topicRepository.Add(request);
        }

        public  async Task<EditTopic> Edit(EditTopicRequest request)
        {
            return await topicRepository.Edit(request);
        }

       

        public async Task<IList<GetTopic>> GetsTopicIsNotDelete()
        {
            return await topicRepository.GetsTopicIsNotDelete();
        }

        public async Task<DeleteTopic> Restore(DeleteTopicRequest request)
        {
            return await topicRepository.Restore(request);
        }
    }
}
