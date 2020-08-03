using Microsoft.AspNetCore.Mvc;
using Mp3WebMusic.BAL.INTERFACE.Topics;
using Mp3WebMusic.DOMAIN.Reponse.Topics;
using Mp3WebMusic.DOMAIN.Request.Topics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mp3WebMusic.API.Controllers
{
    public class TopicController: Controller
    {
        private readonly ITopicService topicService;
        public TopicController(ITopicService topicService)
        {
            this.topicService = topicService;
        }
        [HttpGet]
        [Route("/Api/Topic/GetsTopicIsDelete")]
        public  async Task< IEnumerable<GetTopic>> GetsTopicIsDelete()
        {
            return await topicService.GetsTopicIsDelete();    
        }
        [HttpGet]
        [Route("/Api/Topic/GetsTopicIsNotDelete")]
        public async Task<IEnumerable<GetTopic>> GetsTopicIsNotDelete()
        {
            return await topicService.GetsTopicIsNotDelete();
        }
        [HttpGet]
        [Route("/Api/Topic/Get/{id}")]
        public async Task<GetTopic> Get(int id)
        {
            return await topicService.Get(id);
        }
        [HttpPost]
        [Route("/Api/Topic/Add")]
        public async Task<AddTopic> Add(AddTopicRequest request)
        {
            return await topicService.Add(request);
        }
        [HttpPost]
        [Route("/Api/Topic/Edit")]
        public async Task<EditTopic> Edit(EditTopicRequest request)
        {
            return await topicService.Edit(request);
        }
        [HttpPost]
        [Route("/Api/Topic/Delete")]
        public async Task<DeleteTopic> Delete(DeleteTopicRequest request)
        {
            return await topicService.Delete(request);

        }
        [HttpPost]
        [Route("/Api/Topic/Restore")]
        public async Task<DeleteTopic> Restore(DeleteTopicRequest request)
        {
            return await topicService.Restore(request);

        }
    }
}
