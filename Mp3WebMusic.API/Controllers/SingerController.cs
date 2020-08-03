using Microsoft.AspNetCore.Mvc;
using Mp3WebMusic.DAL.INTERFACE.Singers;
using Mp3WebMusic.DOMAIN.Reponse.Singers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mp3WebMusic.API.Controllers
{
    public class SingerController: Controller
    {

        private ISingerService singerService;
        public SingerController(ISingerService singerService)
        {
            this.singerService = singerService;
        }
        [HttpGet]
        [Route("/Api/Singer/GetsSingerIsDelete")]
        public async Task<IEnumerable<GetSinger>> GetsSingerIsDelete()
        {
            return await singerService.GetsSingerIsDelete();
        }
        [HttpGet]
        [Route("/Api/Singer/GetsSingerIsNotDelete")]
        public async Task<IEnumerable<GetSinger>> GetsSingerIsNotDelete()
        {
            return await singerService.GetsSingerIsNotDelete();
        }
        [HttpGet]
        [Route("/Api/Singer/GetsSingerByID/{SingerID}")]
        public async Task<GetSinger> Get(int SingerID)
        {
            return await singerService.Get(SingerID);
        }
        [HttpPost]
        [Route("/Api/Singer/Add")]
        public async Task<AddSinger> Add(AddSingerRequest request)
        {
            return await singerService.Add(request);
        }
        [HttpPost]
        [Route("/Api/Singer/Edit")]
        public async Task<EditSinger> Edit(EditSingerRequest request)
        {
            return await singerService.Edit(request);
        }
        [HttpPost]
        [Route("/Api/Singer/Delete")]
        public async Task<DeleteSinger> Delete(DeleteSingerRequest request)
        {
            return await singerService.Delete(request);
        }
        [HttpPost]
        [Route("/Api/Singer/Restore")]
        public async Task<DeleteSinger> Restore(DeleteSingerRequest request)
        {
            return await singerService.Restore(request);
        }
    }
}
