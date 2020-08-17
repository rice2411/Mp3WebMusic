using Microsoft.AspNetCore.Mvc;
using Mp3WebMusic.BAL.INTERFACE.Topics;
using Mp3WebMusic.DOMAIN.Request.Topics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mp3WebMusic.API.Controllers
{
    [ApiController]
    public class TopicController: Controller
    {
        private readonly ITopicService topicService;
        public TopicController(ITopicService topicService)
        {
            this.topicService = topicService;
        }
        [HttpGet]
        [Route("/Api/Topic/GetsTopicIsDelete")]
        public  async Task< IEnumerable<Topic>> GetsTopicIsDelete()
        {
            return await topicService.GetsTopicIsDelete();    
        }
        [HttpGet]
        [Route("/Api/Topic/GetsTopicTop4")]
        public async Task<IEnumerable<Topic>> GetsTopicTop4()
        {
            return await topicService.GetsTopicTop4();
        }
        [HttpGet]
        [Route("/Api/Topic/GetsTopicIsNotDelete")]
        public async Task<IEnumerable<Topic>> GetsTopicIsNotDelete()
        {
            return await topicService.GetsTopicIsNotDelete();
        }
        [HttpGet]
        [Route("/Api/Topic/Get/{id}")]
        public async Task<Topic> Get(int id)
        {
            return await topicService.Get(id);
        }
        [HttpPost]
        [Route("/Api/Topic/Add")]
        public async Task<Topic> Add(Topic request)
        {
            return await topicService.Add(request);
        }
        [HttpPost]
        [Route("/Api/Topic/Edit")]
        public async Task<Topic> Edit(Topic request)
        {
            return await topicService.Edit(request);
        }
        [HttpPost]
        [Route("/Api/Topic/Delete/{id}")]
        public async Task<Topic> Delete(int id)
        {
            return await topicService.Delete(id);

        }
        [HttpPost]
        [Route("/Api/Topic/Restore/{id}")]
        public async Task<Topic> Restore(int id)
        {
            return await topicService.Restore(id);

        }
    }
}
