using Dapper;
using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Reponse.Types;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Mp3WebMusic.DAL.Type
{
    public class TypeRepository : BaseRepository, ITypeRepository
    {

        public IList<Types> GetsTypeIsDelete()
        {
            IList<Types> types = SqlMapper.Query<Types>(connection, "TypeGetsIsDelete", commandType: CommandType.StoredProcedure).ToList();
            return types;
        }
        public Types GetTypeById(int typeid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TypeID", typeid);
            Types type = SqlMapper.Query<Types>(connection, "TypeGetByID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return type;
        }

        public IList<Types> GetsTypeIsNotDelete()
        {
            IList<Types> types = SqlMapper.Query<Types>(connection, "TypeGetsIsNotDelete", commandType: CommandType.StoredProcedure).ToList();
            return types;
        }
        public Types AddType(AddType request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();


                parameters.Add("@TypeName", request.TypeName);
                parameters.Add("@TypeID", request.TypeID);


                var model = SqlMapper.QueryFirstOrDefault<Types>(connection, "TypeAdd", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Types()
                {
                    Message = e.Message
                };
            }
        }
        public Types DeleteType(int request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TypeID", request);
                var model = SqlMapper.QueryFirstOrDefault<Types>(connection, "TypeDelete", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Types()
                {
                    Message = e.Message
                };
            }
        }
        public Types EditType(EditType request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TypeID", request.TypeID);
                parameters.Add("@TypeName", request.TypeName);



                var model = SqlMapper.QueryFirstOrDefault<Types>(connection, "TypeEdit", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Types()
                {
                    Message = e.Message
                };
            }
        }
        public Types RestoreType(int request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TypeID", request);
                var model = SqlMapper.QueryFirstOrDefault<Types>(connection, "TypeRestore", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Types()
                {
                    Message = e.Message
                };
            }
        }
    }
}

        


    
