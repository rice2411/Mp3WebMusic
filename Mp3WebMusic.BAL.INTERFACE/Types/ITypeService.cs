using Mp3WebMusic.DOMAIN.Reponse.Types;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL.INTERFACE.Types
{
    public interface ITypeService
    {
        IList<TypeResult> GetsTypeIsnotDelete();
    }
}
