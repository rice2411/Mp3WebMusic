﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN
{
    public class ApplicationUser : IdentityUser
    {
        public string Avatar { get; set; }
    }
}
