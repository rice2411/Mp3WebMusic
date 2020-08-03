﻿using Mp3WebMusic.DOMAIN.Reponse;
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
        IList<TypeResult> GetsTypeIsnotDelete();
        IList<TypeResult> GetsByType(int typeid);
        TypeResultById GetTypeById(int typeid);
        Messages AddType(AddType request);
        Messages DeleteType(DeleteType request);
        Messages EditType(EditType request);
        Messages RestoreType(RestoreType request);

    }
}
