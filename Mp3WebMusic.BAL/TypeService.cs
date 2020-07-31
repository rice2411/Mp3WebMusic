﻿using Mp3WebMusic.BAL.INTERFACE;
using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DOMAIN.Reponse;
using System;
using System.Collections.Generic;

namespace Mp3WebMusic.BAL
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
    }
}
