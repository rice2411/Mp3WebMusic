using Mp3WebMusic.DOMAIN.Reponse;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Reponse.Types;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DAL.INTERFACE
{
    public interface ITypeRepository
    {
        IList<Types> GetsTypeIsNotDelete();
        IList<Types> GetsTypeIsDelete();
        Types GetTypeById(int typeid);
        Types AddType(AddType request);
        Types DeleteType(int id);
        Types EditType(EditType request);
        Types RestoreType(int id);

    }
}
