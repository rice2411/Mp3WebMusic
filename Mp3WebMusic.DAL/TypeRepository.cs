using Dapper;
using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DOMAIN.Reponse;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Mp3WebMusic.DAL
{
    public class TypeRepository : BaseRepository, ITypeRepository
    {
        public IList<TypeResult> GetsTypeIsnotDelete()
        {
            IList<TypeResult> types = SqlMapper.Query<TypeResult>(connection, "TypeGetsIsNotDelete", commandType: CommandType.StoredProcedure).ToList();
            return types;
        }
    }
}
