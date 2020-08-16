using Dapper;
using Mp3WebMusic.DAL.INTERFACE.Banner;
using Mp3WebMusic.DOMAIN.Request_Reponse.Banner;
using System;
using System.Collections.Generic;

using System.Data;
using System.Linq;

namespace Mp3WebMusic.DAL.Banner
{
    public class BannerRepository : BaseRepository,IBannerRepository
    {
       

        public Banners AddBanner(Banners request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Banner", request.Banner);
          
                var model = SqlMapper.QueryFirstOrDefault<Banners>(connection, "BannerAdd", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Banners()
                {
                    Message = e.Message
                };
            }
        }

        public Banners DeleteBanner(int id)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BannerID", id);
                Banners song = SqlMapper.Query<Banners>(connection, "BannerDelete", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return song;
            }
            catch (Exception e)
            {
                return new Banners()
                {
                    Message = e.Message
                };
            }
           
        }

        public Banners EditBanner(Banners request)
        {
            try
            {

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Banner", request.Banner);
                parameters.Add("@BannerID", request.BannerID);
                var model = SqlMapper.QueryFirstOrDefault<Banners>(connection, "BannerEdit", parameters, commandType: CommandType.StoredProcedure);
                return model;
            }
            catch (Exception e)
            {
                return new Banners()
                {
                    Message = e.Message
                };
            }
        }

        public Banners GetBannerById(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@BannerID", id);
            Banners songs = SqlMapper.Query<Banners>(connection, "BannerGetID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return songs;
        }

        public IList<Banners> GetsBanner()
        {
            IList<Banners> songs = SqlMapper.Query<Banners>(connection, "BannerGets", commandType: CommandType.StoredProcedure).ToList();
            return songs;
        }
    }
}
