using Mp3WebMusic.DOMAIN.Request_Reponse.Banner;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.BAL.INTERFACE.Banner
{
    public interface IBannerService
    {
        IList<Banners> GetsBanner();
        IList<Banners> GetsBannerIsNotDelete();
        Banners GetBannerById(int id);
        Banners AddBanner(Banners request);
        Banners DeleteBanner(int id);
        Banners EditBanner(Banners request);
        Banners RestoreBanner(int id);
    }
}
