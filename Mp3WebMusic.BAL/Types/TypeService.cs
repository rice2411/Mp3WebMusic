using Mp3WebMusic.BAL.INTERFACE;
using Mp3WebMusic.BAL.INTERFACE.Songs;
using Mp3WebMusic.BAL.INTERFACE.Types;
using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DOMAIN.Reponse;
using Mp3WebMusic.DOMAIN.Reponse.Types;
using System;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL.Types
{
    public class TypeService : ITypeService
    {
        private ITypeRepository typeRepository;
        public TypeService(ITypeRepository typeRepository)
        {
            this.typeRepository = typeRepository;
        }

        public IList<Typeresult> GetsTypeIsnotDelete()
        {
            return typeRepository.GetsTypeIsnotDelete();
        }

       
    }
}
