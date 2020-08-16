using Mp3WebMusic.BAL.INTERFACE.Type;

using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DAL.INTERFACE.Banner;
using Mp3WebMusic.DOMAIN.Request.Type;
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

        public Types AddType(Types request)
        {
            return typeRepository.AddType(request);
        }
        public Types DeleteType(int request)
        {
            return typeRepository.DeleteType(request);
        }
        public Types EditType(Types request)
        {
            return typeRepository.EditType(request);
        }
        public Types RestoreType(int request)
        {
            return typeRepository.RestoreType(request);
        }
    }
}
