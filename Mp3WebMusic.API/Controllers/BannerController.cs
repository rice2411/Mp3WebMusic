using Microsoft.AspNetCore.Mvc;
using Mp3WebMusic.BAL.INTERFACE.Banner;
using Mp3WebMusic.DOMAIN.Request_Reponse.Banner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mp3WebMusic.API.Controllers
{
    [ApiController]
    public class BannerController : Controller
    {
        private readonly IBannerService bannerService;
        public BannerController(IBannerService bannerService)
        {
            this.bannerService = bannerService;
        }
        [HttpGet]
        [Route("/Api/Banner/Gets")]
        public IEnumerable<Banners> GetsBanner()
        {
            return bannerService.GetsBanner();
        }
        [HttpPost]
        [Route("/Api/Banner/AddBanner")]
        public Banners AddBanner(Banners request)
        {
            return bannerService.AddBanner(request);
        }
        [HttpPost]
        [Route("/Api/Banner/EditBanner")]
        public Banners EditBanner(Banners request)
        {
            return bannerService.EditBanner(request);
        }
        [HttpDelete]
        [Route("/Api/Banner/DeleteBanner/{id}")]
        public Banners DeleteBanner(int id)
        {
            return bannerService.DeleteBanner(id);
        }
        [HttpGet]
        [Route("/Api/Banner/GetBannerByID/{id}")]
        public Banners GetBannerByID(int id)
        {
            return bannerService.GetBannerById(id);
        }
    }
}
