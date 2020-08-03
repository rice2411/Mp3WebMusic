using Mp3WebMusic.DOMAIN.Reponse;
using Mp3WebMusic.DOMAIN.Reponse.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DAL.INTERFACE
{
    public interface ITypeRepository
    {
        IList<Typeresult> GetsTypeIsnotDelete();
    }
}
