using Dapper;
using Mp3WebMusic.DAL.INTERFACE;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Reponse.Types;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Mp3WebMusic.DAL.Types
{
    public class TypeRepository : BaseRepository, ITypeRepository
    {

        public IList<TypeResult> GetsByType(int typeid)
        {
            IList<TypeResult> types = SqlMapper.Query<TypeResult>(connection, "TypeGetsIsDelete", commandType: CommandType.StoredProcedure).ToList();
            return types;
        }
        public TypeResultById GetTypeById(int typeid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TypeID", typeid);
            TypeResultById type = SqlMapper.Query<TypeResultById>(connection, "TypeGetByID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return type;
        }

        public IList<TypeResult> GetsTypeIsnotDelete()
        {
            IList<TypeResult> types = SqlMapper.Query<TypeResult>(connection, "TypeGetsIsNotDelete", commandType: CommandType.StoredProcedure).ToList();
            return types;
        }
        public Messages AddType(AddType request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();


                parameters.Add("@TypeName", request.TypeName);
                parameters.Add("@TypeID", request.TypeID);


                var model = SqlMapper.QueryFirstOrDefault<Messages>(connection, "TypeAdd", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Messages()
                {
                    Message = "Something went wrong"
                };
            }
        }
        public Messages DeleteType(DeleteType request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TypeID", request.TypeID);
                var model = SqlMapper.QueryFirstOrDefault<Messages>(connection, "TypeDelete", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Messages()
                {
                    Message = "Something went wrong"
                };
            }
        }
        public Messages EditType(EditType request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TypeID", request.TypeID);
                parameters.Add("@TypeName", request.TypeName);



                var model = SqlMapper.QueryFirstOrDefault<Messages>(connection, "TypeEdit", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Messages()
                {
                    Message = "Something went wrong"
                };
            }
        }
        public Messages RestoreType(RestoreType request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TypeID", request.TypeID);
                var model = SqlMapper.QueryFirstOrDefault<Messages>(connection, "TypeRestore", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Messages()
                {
                    Message = "Something went wrong"
                };
            }
        }
    }
}

        


    
