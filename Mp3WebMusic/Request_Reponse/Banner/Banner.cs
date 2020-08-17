using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Request_Reponse.Banner
{
    public class Banners
    {
        public int BannerID { get; set; }
        public string Banner { get; set; }
        public string Message { get; set; }
        public bool IsDelete { get; set; }
    }
}
