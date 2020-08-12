using Mp3WebMusic.DAL.INTERFACE.Singers;
using Mp3WebMusic.DOMAIN.Request.Singers;
using System.Collections.Generic;
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
        public async Task<Singer> Add(Singer request)
        {
            return await singerRepository.Add(request);
        }

        public async Task<Singer> Delete(int request)
        {
            return await singerRepository.Delete(request);
        }

        public async Task<Singer> Edit(Singer request)
        {
            return await singerRepository.Edit(request);
        }

        public async Task<Singer> Get(int SingerID)
        {
            return await singerRepository.Get(SingerID);
        }

        public  async Task<IList<Singer>> GetsSingerIsDelete()
        {
            return await singerRepository.GetsSingerIsDelete();

        }

        public async Task<IList<Singer>> GetsSingerIsNotDelete()
        {
            return await singerRepository.GetsSingerIsNotDelete();
        }

        public async Task<Singer> Restore(int request)
        {
            return await singerRepository.Restore(request);
            
        }
    }
}
