using Mp3WebMusic.DOMAIN.Reponse.Singers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mp3WebMusic.DAL.INTERFACE.Singers
{
     public interface ISingerRepository
    {
        Task<IList<Singer>> GetsSingerIsNotDelete();
        Task<IList<Singer>> GetsSingerIsDelete();

        Task<Singer> Get(int SingerID);
        Task<Singer> Delete(int SingerID);
        Task<Singer> Restore(int SingerID);
        Task<Singer> Add(AddSingerRequest request);
        Task<Singer> Edit(EditSingerRequest request);
    }
}
