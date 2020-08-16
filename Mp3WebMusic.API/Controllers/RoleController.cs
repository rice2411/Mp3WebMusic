using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mp3WebMusic.DOMAIN;
using Mp3WebMusic.DOMAIN.Reponse.Account;
using Mp3WebMusic.DOMAIN.Request.Account;
using Mp3WebMusic.DOMAIN.Request.Role;
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
 

    public class RoleController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        [HttpGet]
        [Route("/Api/Role/GetAll")]
        public async Task<IEnumerable<Role>> GetAll()
        {
            var roles = roleManager.Roles;
            var model = new List<Role>();
            model = roles.Select(r => new Role()
            {
                RoleID = r.Id,
                RoleName = r.Name,

            }).ToList();
            return model;
        }
        [HttpPost]
        [Route("/Api/Role/Add")]
        public async Task<Role> Add (RoleAdd model)
        {
            var result = new Role()
            {
                Message = "something went wrong, please try again",

                RoleID = string.Empty
            };
            var addresult = await roleManager.CreateAsync(new IdentityRole()
            {
                Name = model.RoleName
                
            });
            if (addresult.Succeeded)
            {
                result.Message = "Add Role succeeded";
            };

            return result;
        }
        [HttpGet]
        [Route("/Api/Role/Get/{id}")]
        public async Task<Role> Get(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            
                var model = new Role()
                {
                    RoleID=role.Id,
                    RoleName=role.Name,
                    
                    
                };

                return model;
            

           
        }
        [HttpPost]
        [Route("/Api/Role/Edit")]
        public async Task<Role> Edit(Role model)
        {


            var result = new Role()
            {
                Message = "something went wrong, please try again",

                RoleID = model.RoleID
            };
            var editrole = await roleManager.UpdateAsync(new IdentityRole
            {
                Name = model.RoleName
            });


            if (editrole.Succeeded)
            {
                result.Message = "Edit Role succeeded";
            };

            return result;
           


        }
        [HttpDelete]
        [Route("/Api/Role/Delete")]
        public async Task<Role> Delete(Role model)
        {


            var result = new Role()
            {
                Message = "something went wrong, please try again",

                RoleID = model.RoleID
            };
            var editrole = await roleManager.DeleteAsync(new IdentityRole
            {
                Id=model.RoleID
            });


            if (editrole.Succeeded)
            {
                result.Message = "Delete Role succeeded";
            };

            return result;



        }

    }
}

