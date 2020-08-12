using Mp3WebMusic.DOMAIN.Request.Type;
using System.Collections.Generic;

namespace Mp3WebMusic.DAL.INTERFACE
{
    public interface ITypeRepository
    {
        IList<Types> GetsTypeIsNotDelete();
        IList<Types> GetsTypeIsDelete();
        Types GetTypeById(int typeid);
        Types AddType(Types request);
        Types DeleteType(int id);
        Types EditType(Types request);
        Types RestoreType(int id);

    }
}
