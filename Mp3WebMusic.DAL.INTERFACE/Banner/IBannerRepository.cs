using System;
using System.Collections.Generic;
using System.Text;
using Mp3WebMusic.DOMAIN.Request_Reponse.Banner;

namespace Mp3WebMusic.DAL.INTERFACE.Banner
{
    public interface IBannerRepository
    {
        IList<Banners> GetsBanner();
        IList<Banners> GetsBannerIsNotDelete();
        Banners AddBanner(Banners request);
        Banners DeleteBanner(int id);
        Banners EditBanner(Banners request);
        Banners GetBannerById(int id);
        Banners RestoreBanner(int id);
    }
}
