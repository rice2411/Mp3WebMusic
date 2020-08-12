using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Reponse.Types;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL.INTERFACE.Type
{
    public interface ITypeService
    {
        IList<Types> GetsTypeIsNotDelete();
        IList<Types> GetsTypeIsDelete();
        Types GetTypeById(int typeid);
        Types AddType(AddType request);
        Types DeleteType(int request);
        Types EditType(EditType request);
        Types RestoreType(int request);
    }
}
