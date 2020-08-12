using Microsoft.AspNetCore.Mvc;
using Mp3WebMusic.BAL.INTERFACE.Type;

using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Reponse.Types;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System.Collections.Generic;

namespace Mp3WebMusic.API.Controllers
{
    [ApiController]
    public class TypeController : Controller
        
    {
        private readonly ITypeService typeService;
        public TypeController(ITypeService typeService)
        {
            this.typeService = typeService;
        }
        [HttpGet]
        [Route("/Api/Type/GetsTypeIsNotDelete")]
        public IEnumerable<Types> GetsTypeIsnotDelete()
        {
            return typeService.GetsTypeIsNotDelete();
        }
        [HttpGet]
        [Route("/Api/Type/GetsTypeIsDelete")]
        public IList<Types> GetsTypeIsDelete()
        {
            return typeService.GetsTypeIsDelete();
        }
        [HttpGet]
        [Route("/Api/Type/GetTypeById/{id}")]
        public Types GetTypeById(int id)
        {
            return typeService.GetTypeById(id);
        }
        [HttpPost]
        [Route("/Api/Type/AddType")]
        public Types AddType(AddType request)
        {
            return typeService.AddType(request);
        }

        [HttpPost]
        [Route("/Api/Type/DeleteType/{id}")]
        public Types DeleteType(int request)
        {
            return typeService.DeleteType(request);
        }
        [HttpPost]
        [Route("/Api/Type/EditType")]
        public Types EditType(EditType request)
        {
            return typeService.EditType(request);
        }
        [HttpPost]
        [Route("/Api/Type/RestoreType/{id}")]
        public Types RestoreType(int id)
        {
            return typeService.RestoreType(id);
        }
    }
}
