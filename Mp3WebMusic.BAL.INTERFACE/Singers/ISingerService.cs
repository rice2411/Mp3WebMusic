using Mp3WebMusic.DOMAIN.Reponse.Singers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mp3WebMusic.DAL.INTERFACE.Singers
{
     public interface ISingerService
    {
        Task<IList<GetSinger>> GetsSingerIsNotDelete();
        Task<IList<GetSinger>> GetsSingerIsDelete();

        Task<GetSinger> Get(int SingerID);
        Task<DeleteSinger> Delete(DeleteSingerRequest request);
        Task<DeleteSinger> Restore(DeleteSingerRequest request);

        Task<AddSinger> Add(AddSingerRequest request);
        Task<EditSinger> Edit(EditSingerRequest request);
    }
}
