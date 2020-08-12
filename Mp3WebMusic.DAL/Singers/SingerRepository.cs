using Dapper;
using Mp3WebMusic.DAL.INTERFACE.Singers;
using Mp3WebMusic.DOMAIN.Request.Singers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Mp3WebMusic.DAL.Singers
{
    public class SingerRepository :BaseRepository, ISingerRepository
    {
        public async Task<Singer> Add(Singer request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SingerName", request.SingerName);
                parameters.Add("@SingerNickName", request.SingerNickName);
                parameters.Add("@Introduce", request.Introduce);
                parameters.Add("@Avatar", request.Avatar);


                var model = SqlMapper.QueryFirstOrDefault<Singer>(connection, "SingerAdd", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Singer()
                {
                    Message = e.Message
                };
            }
        }

        public async Task<Singer> Delete(int request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SingerID", request);

                var model = SqlMapper.QueryFirstOrDefault<Singer>(connection, "SingerDelete", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Singer()
                {
                    Message = e.Message
                };
            }

        }

        public async Task<Singer> Edit(Singer request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SingerID", request.SingerID);
                parameters.Add("@SingerName", request.SingerName);
                parameters.Add("@SingerNickName", request.SingerNickName);
                parameters.Add("@Introduce", request.Introduce);
                parameters.Add("@Avatar", request.Avatar);


                var model = SqlMapper.QueryFirstOrDefault<Singer>(connection, "SingerEdit", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Singer()
                {
                    Message = e.Message
                };
            }
        }

        public async Task<Singer> Get(int SingerID)
        {

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SingerID",SingerID);
            return (await SqlMapper.QueryFirstOrDefaultAsync<Singer>(cnn: connection,
                             param: parameters,
                            sql: "SingerGetByID",
                            commandType: CommandType.StoredProcedure));
        }

        public async Task<IList<Singer>> GetsSingerIsDelete()
        {

            IList<Singer> singers = SqlMapper.Query<Singer>(connection, "SingerGetsIsDelete", commandType: CommandType.StoredProcedure).ToList();
            return singers;
        }

        public async Task<IList<Singer>> GetsSingerIsNotDelete()
        {
            IList<Singer> singers = SqlMapper.Query<Singer>(connection, "SingerGetsIsNotDelete", commandType: CommandType.StoredProcedure).ToList();
            return singers;
        }

        public async Task<Singer> Restore(int request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SingerID", request);

                var model = SqlMapper.QueryFirstOrDefault<Singer>(connection, "SingerRestore", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Singer()
                {
                    Message = e.Message
                };
            }


        }
    }
}
