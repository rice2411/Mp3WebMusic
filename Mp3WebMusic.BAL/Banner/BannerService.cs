using Mp3WebMusic.BAL.INTERFACE.Banner;
using Mp3WebMusic.DAL.INTERFACE.Banner;
using Mp3WebMusic.DOMAIN.Request_Reponse.Banner;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.BAL.Banner
{
    public class BannerService : IBannerService
    {
        private IBannerRepository bannerRepository;
        public BannerService(IBannerRepository bannerRepository)
        {
            this.bannerRepository = bannerRepository;
        }
        public Banners AddBanner(Banners request)
        {
            return bannerRepository.AddBanner(request);
        }

        public Banners DeleteBanner(int id)
        {
            return bannerRepository.DeleteBanner(id);
        }
        public Banners RestoreBanner(int id)
        {
            return bannerRepository.RestoreBanner(id);
        }
        public Banners EditBanner(Banners request)
        {
            return bannerRepository.EditBanner(request);
        }

        public Banners GetBannerById(int id)
        {
            return bannerRepository.GetBannerById(id);
        }

        public IList<Banners> GetsBanner()
        {
            return bannerRepository.GetsBanner();
        }
        public IList<Banners> GetsBannerIsNotDelete()
        {
            return bannerRepository.GetsBannerIsNotDelete();
        }
    }
}
