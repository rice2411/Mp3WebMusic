using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mp3WebMusic.DOMAIN;
using Mp3WebMusic.DOMAIN.Reponse.Account;
using Mp3WebMusic.DOMAIN.Request.Account;
using Mp3WebMusic.DOMAIN.Request.User;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mp3WebMusic.API.Controllers
{
    /// <summary>
    /// Department API
    /// </summary>
    [ApiController]
    [Route("[controller]")]

    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        
    }
}

