using Microsoft.AspNetCore.Mvc;
using Mp3WebMusic.DAL.INTERFACE.Singers;
using Mp3WebMusic.DOMAIN.Reponse.Singers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mp3WebMusic.API.Controllers
{
    [ApiController]
    public class SingerController: Controller
    {

        private ISingerService singerService;
        public SingerController(ISingerService singerService)
        {
            this.singerService = singerService;
        }
        [HttpGet]
        [Route("/Api/Singer/GetsSingerIsDelete")]
        public async Task<IEnumerable<Singer>> GetsSingerIsDelete()
        {
            return await singerService.GetsSingerIsDelete();
        }
        [HttpGet]
        [Route("/Api/Singer/GetsSingerIsNotDelete")]
        public async Task<IEnumerable<Singer>> GetsSingerIsNotDelete()
        {
            return await singerService.GetsSingerIsNotDelete();
        }
        [HttpGet]
        [Route("/Api/Singer/GetsSingerByID/{id}")]
        public async Task<Singer> Get(int id)
        {
            return await singerService.Get(id);
        }
        [HttpPost]
        [Route("/Api/Singer/Add")]
        public async Task<Singer> Add(AddSingerRequest request)
        {
            return await singerService.Add(request);
        }
        [HttpPost]
        [Route("/Api/Singer/Edit")]
        public async Task<Singer> Edit(EditSingerRequest request)
        {
            return await singerService.Edit(request);
        }
        [HttpPost]
        [Route("/Api/Singer/Delete/{id}")]
        public async Task<Singer> Delete(int id)
        {
            return await singerService.Delete(id);
        }
        [HttpPost]
        [Route("/Api/Singer/Restore/{id}")]
        public async Task<Singer> Restore(int id)
        {
            return await singerService.Restore(id);
        }
    }
}
