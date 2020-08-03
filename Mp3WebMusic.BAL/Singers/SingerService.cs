using Mp3WebMusic.DAL.INTERFACE.Singers;
using Mp3WebMusic.DOMAIN.Reponse.Singers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mp3WebMusic.BAL.Singers
{
    public class SingerService : ISingerService
    {
        private ISingerRepository singerRepository;
        public SingerService(ISingerRepository singerRepository)
        {
            this.singerRepository = singerRepository;
        }
        public async Task<AddSinger> Add(AddSingerRequest request)
        {
            return await singerRepository.Add(request);
        }

        public async Task<DeleteSinger> Delete(DeleteSingerRequest request)
        {
            return await singerRepository.Delete(request);
        }

        public async Task<EditSinger> Edit(EditSingerRequest request)
        {
            return await singerRepository.Edit(request);
        }

        public async Task<GetSinger> Get(int SingerID)
        {
            return await singerRepository.Get(SingerID);
        }

        public  async Task<IList<GetSinger>> GetsSingerIsDelete()
        {
            return await singerRepository.GetsSingerIsDelete();

        }

        public async Task<IList<GetSinger>> GetsSingerIsNotDelete()
        {
            return await singerRepository.GetsSingerIsNotDelete();
        }

        public async Task<DeleteSinger> Restore(DeleteSingerRequest request)
        {
            return await singerRepository.Restore(request);
            
        }
    }
}
