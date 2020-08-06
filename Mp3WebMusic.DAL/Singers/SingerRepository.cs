using Dapper;
using Mp3WebMusic.DAL.INTERFACE.Singers;
using Mp3WebMusic.DOMAIN.Reponse.Singers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mp3WebMusic.DAL.Singers
{
    public class SingerRepository :BaseRepository, ISingerRepository
    {
        public async Task<AddSinger> Add(AddSingerRequest request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SingerName", request.SingerName);
                parameters.Add("@SingerNickName", request.SingerNickName);
                parameters.Add("@Introduce", request.Introduce);
                parameters.Add("@Avatar", request.Avatar);


                var model = SqlMapper.QueryFirstOrDefault<AddSinger>(connection, "SingerAdd", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new AddSinger()
                {
                    Message = "Something went wrong, please try again"
                };
            }
        }

        public async Task<DeleteSinger> Delete(DeleteSingerRequest request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SingerID", request.SingerID);

                var model = SqlMapper.QueryFirstOrDefault<DeleteSinger>(connection, "SingerDelete", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new DeleteSinger()
                {
                    Message = "Something went wrong, please try again"
                };
            }

        }

        public async Task<EditSinger> Edit(EditSingerRequest request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SingerID", request.SingerID);
                parameters.Add("@SingerName", request.SingerName);
                parameters.Add("@SingerNickName", request.SingerNickName);
                parameters.Add("@Introduce", request.Introduce);
                parameters.Add("@Avatar", request.Avatar);


                var model = SqlMapper.QueryFirstOrDefault<EditSinger>(connection, "SingerEdit", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new EditSinger()
                {
                    Message = "Something went wrong, please try again"
                };
            }
        }

        public async Task<GetSinger> Get(int SingerID)
        {

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SingerID",SingerID);
            return (await SqlMapper.QueryFirstOrDefaultAsync<GetSinger>(cnn: connection,
                             param: parameters,
                            sql: "SingerGetByID",
                            commandType: CommandType.StoredProcedure));
        }

        public async Task<IList<GetSinger>> GetsSingerIsDelete()
        {

            IList<GetSinger> singers = SqlMapper.Query<GetSinger>(connection, "SingerGetsIsDelete", commandType: CommandType.StoredProcedure).ToList();
            return singers;
        }

        public async Task<IList<GetSinger>> GetsSingerIsNotDelete()
        {
            IList<GetSinger> singers = SqlMapper.Query<GetSinger>(connection, "SingerGetsIsNotDelete", commandType: CommandType.StoredProcedure).ToList();
            return singers;
        }

        public async Task<DeleteSinger> Restore(DeleteSingerRequest request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SingerID", request.SingerID);

                var model = SqlMapper.QueryFirstOrDefault<DeleteSinger>(connection, "SingerDelete", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new DeleteSinger()
                {
                    Message = "Something went wrong, please try again"
                };
            }


        }
    }
}
