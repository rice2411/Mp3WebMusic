using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mp3WebMusic.DOMAIN;
using Mp3WebMusic.DOMAIN.Reponse.Account;
using Mp3WebMusic.DOMAIN.Request.Account;
using System.Threading.Tasks;

namespace Mp3WebMusic.API.Controllers
{
    /// <summary>
    /// Department API
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        
       // private readonly ILogger<DepartmentController> _logger;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(//ILogger<DepartmentController> logger,
                                    UserManager<ApplicationUser> userManager,
                                    SignInManager<ApplicationUser> signInManager,
                                    RoleManager<IdentityRole> roleManager)
        {
           // _logger = logger;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        [HttpPost]
        [Route("/Api/Account/Login")]
        public async Task<LoginResult> Login(LoginRequest request)
        {
            var result = new LoginResult()
            {
                Message = "something went wrong, please try again",
                Success = false,
                UserId = string.Empty
            };

            var siginResult =  await signInManager.PasswordSignInAsync(request.Email, request.Password, false, false);

            if (siginResult.Succeeded)
            {
                var user = await userManager.FindByNameAsync(request.Email);
                if(user != null)
                {
                    result.Success = siginResult.Succeeded;
                    result.UserId = user.Id;
                    result.Message = "Login success";
                }
            }

            return result;
        }

        [HttpPost]
        [Route("/Api/Account/Register")]
        public async Task<RegisterResult> Register(RegisterRequest request)
        {
            var result = new RegisterResult()
            {
                Message = "something went wrong, please try again",
                Success = false
            };

            var user = new ApplicationUser()
            {
                Email = request.Email,
                UserName = request.Email,
                Avatar = request.Avatar

                
            };
            var registerResult = await userManager.CreateAsync(user, request.Password);
            if (registerResult.Succeeded)
            {
                result.Message = "Register success";
                result.Success = registerResult.Succeeded;
            }
            return result;
        }
        //[HttpPost]
        //public async Task<IActionResult> Logout()
        //{
        //    await signInManager.SignOutAsync();
        //    return RedirectToAction("Index", "Home");
        //}
    }
}

