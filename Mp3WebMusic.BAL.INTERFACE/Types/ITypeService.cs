using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Reponse.Types;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL.INTERFACE.Types
{
    public interface ITypeService
    {
        IList<TypeResult> GetsTypeIsNotDelete();
        IList<TypeResult> GetsTypeIsDelete();
        TypeResultById GetTypeById(int typeid);
        Messages AddType(AddType request);
        Messages DeleteType(DeleteType request);
        Messages EditType(EditType request);
        Messages RestoreType(RestoreType request);
    }
}
