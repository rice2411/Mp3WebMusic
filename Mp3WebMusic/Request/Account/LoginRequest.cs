using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Request.Account
{ 
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
