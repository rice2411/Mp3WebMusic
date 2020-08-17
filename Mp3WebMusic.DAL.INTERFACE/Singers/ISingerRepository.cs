using Mp3WebMusic.DOMAIN.Request.Singers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mp3WebMusic.DAL.INTERFACE.Singers
{
    public interface ISingerRepository
    {
        Task<IList<Singer>> GetsSingerIsNotDelete();
        Task<IList<Singer>> GetsSingerIsDelete();
        Task<IList<Singer>> GetsSingerTop4();
        Task<Singer> Get(int SingerID);
        Task<Singer> Delete(int SingerID);
        Task<Singer> Restore(int SingerID);
        Task<Singer> Add(Singer request);
        Task<Singer> Edit(Singer request);
    }
}
