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

        //[HttpGet]
        //[Route("/Api/User/Gets")]
        //public async Task<List<User>> Gets()
        //{
        //    // var user = await userManager.GetUserAsync(HttpContext.User);
        //    var users = userManager.Users;
        //    if (users != null)
        //    {
        //        var models = new List<User>();
        //        models = users.Select(u => new User()
        //        {
        //            UserID = u.Id,
        //            UserName = u.UserName,
        //            Email = u.Email,
        //            Avatar = u.Avatar,
        //            Password = u.PasswordHash
        //        }).ToList();
        //        foreach (var user in models)
        //        {
        //            user.RolesName = GetRoleName(user.UserID);
        //        }
        //        return  models;
        //    }
        //}
        //public string GetRoleName(string userId)
        //{
        //    var user = Task.Run(async () => await userManager.FindByIdAsync(userId)).Result;
        //    var roles = Task.Run(async () => await userManager.GetRolesAsync(user)).Result;
        //    return roles != null ? string.Join(",", roles) : string.Empty;
        //}
    }
}

