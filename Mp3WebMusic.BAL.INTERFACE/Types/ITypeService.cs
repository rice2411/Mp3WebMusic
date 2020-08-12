using Mp3WebMusic.DOMAIN.Request.Type;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL.INTERFACE.Type
{
    public interface ITypeService
    {
        IList<Types> GetsTypeIsNotDelete();
        IList<Types> GetsTypeIsDelete();
        Types GetTypeById(int typeid);
        Types AddType(Types request);
        Types DeleteType(int request);
        Types EditType(Types request);
        Types RestoreType(int request);
    }
}
