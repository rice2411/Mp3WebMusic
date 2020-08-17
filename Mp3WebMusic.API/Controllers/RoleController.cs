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
        private RoleManager<ApplicationRole> roleManager;
        public RoleController(RoleManager<ApplicationRole> roleManager)
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
                IsDelete = r.IsDelete                

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
            var addresult = await roleManager.CreateAsync(new ApplicationRole()
            {
                Name = model.RoleName,
                IsDelete = 0

                
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
            try
            {
                var editrole = await roleManager.FindByIdAsync(model.RoleID);
                if (editrole != null)
                {
                    editrole.Name = model.RoleName;
                    var editResult = await roleManager.UpdateAsync(editrole);
                    if (editResult.Succeeded)
                    {
                        result.Message = "Edit Role succeeded";
                    };
                }
            }
            catch (System.Exception e)
            {

                return result;
            }
            return result;
        }
        [HttpPost]
        [Route("/Api/Role/Delete/{id}")]
        public async Task<Role> Delete(string id)
        {
            var result = new Role()
            {
                Message = "something went wrong, please try again",

                RoleID = id
                
            };
            var deleteRole = await roleManager.FindByIdAsync(id);
            if (deleteRole != null)
            {
                deleteRole.IsDelete = 1;
                var deleteResult = await roleManager.UpdateAsync(deleteRole);
                if (deleteResult.Succeeded)
                {
                    result.Message = "Delete Role succeeded";
                };
            }
            
            return result;

        }
        [HttpPost]
        [Route("/Api/Role/Restore/{id}")]
        public async Task<Role> Restore(string id)
        {

            var result = new Role()
            {
                Message = "something went wrong, please try again",

                RoleID = id

            };
            var deleteRole = await roleManager.FindByIdAsync(id);
            if (deleteRole != null)
            {
                deleteRole.IsDelete = 0;
                var deleteResult = await roleManager.UpdateAsync(deleteRole);
                if (deleteResult.Succeeded)
                {
                    result.Message = "Restore Role succeeded";
                };
            }

            return result;

        }


    }
}

