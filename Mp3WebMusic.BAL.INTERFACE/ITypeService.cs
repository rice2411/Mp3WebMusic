using Mp3WebMusic.DOMAIN.Reponse;
using System;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL.INTERFACE
{
    public interface ITypeService
    {
        IList<TypeResult> GetsTypeIsnotDelete();
    }
}
