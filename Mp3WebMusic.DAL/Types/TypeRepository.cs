using Dapper;
using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DOMAIN.Reponse.Types;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Mp3WebMusic.DAL.Types
{
    public class TypeRepository : BaseRepository, ITypeRepository
    {
        public IList<Typeresult> GetsTypeIsnotDelete()
        {
            IList<Typeresult> types = SqlMapper.Query<Typeresult>(connection, "TypeGetsIsNotDelete", commandType: CommandType.StoredProcedure).ToList();
            return types;
        }
    }
}
