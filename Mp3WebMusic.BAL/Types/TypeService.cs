﻿using Mp3WebMusic.BAL.INTERFACE;
using Mp3WebMusic.BAL.INTERFACE.Songs;
using Mp3WebMusic.BAL.INTERFACE.Types;
using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DOMAIN.Reponse;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Reponse.Types;
using Mp3WebMusic.DOMAIN.Request.Songs;
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

        public IList<TypeResult> GetsTypeIsnotDelete()
        {
            return typeRepository.GetsTypeIsnotDelete();
        }
        public IList<TypeResult> GetsByType(int typeid)
        {
            return typeRepository.GetsByType(typeid);
        }

        public TypeResultById GetTypeById(int typeid)
        {
            return typeRepository.GetTypeById(typeid);
        }

        public Messages AddType(AddType request)
        {
            return typeRepository.AddType(request);
        }
        public Messages DeleteType(DeleteType request)
        {
            return typeRepository.DeleteType(request);
        }
        public Messages EditType(EditType request)
        {
            return typeRepository.EditType(request);
        }
        public Messages RestoreType(RestoreType request)
        {
            return typeRepository.RestoreType(request);
        }
    }
}
