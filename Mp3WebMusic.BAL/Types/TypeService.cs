using Mp3WebMusic.BAL.INTERFACE;
using Mp3WebMusic.BAL.INTERFACE.Songs;
using Mp3WebMusic.BAL.INTERFACE.Type;

using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DOMAIN.Reponse;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Reponse.Types;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL.Type
{
    public class TypeService : ITypeService
    {
        private ITypeRepository typeRepository;
        public TypeService(ITypeRepository typeRepository)
        {
            this.typeRepository = typeRepository;
        }

        public IList<Types> GetsTypeIsNotDelete()
        {
            return typeRepository.GetsTypeIsNotDelete();
        }
        public IList<Types> GetsTypeIsDelete()
        {
            return typeRepository.GetsTypeIsDelete();
        }

        public Types GetTypeById(int typeid)
        {
            return typeRepository.GetTypeById(typeid);
        }

        public Types AddType(AddType request)
        {
            return typeRepository.AddType(request);
        }
        public Types DeleteType(int request)
        {
            return typeRepository.DeleteType(request);
        }
        public Types EditType(EditType request)
        {
            return typeRepository.EditType(request);
        }
        public Types RestoreType(int request)
        {
            return typeRepository.RestoreType(request);
        }
    }
}
