
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN
{
    public class ApplicationRole : IdentityRole
    {
        public int IsDelete { get; set; }
    }
}
