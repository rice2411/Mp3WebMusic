using Microsoft.AspNetCore.Mvc;
using Mp3WebMusic.BAL.INTERFACE.Types;
using Mp3WebMusic.DOMAIN.Reponse.Songs;
using Mp3WebMusic.DOMAIN.Reponse.Types;
using Mp3WebMusic.DOMAIN.Request.Songs;
using System.Collections.Generic;

namespace Mp3WebMusic.API.Controllers
{
    public class TypeController : Controller
        
    {
        private readonly ITypeService typeService;
        public TypeController(ITypeService typeService)
        {
            this.typeService = typeService;
        }
        [HttpGet]
        [Route("/Api/Type/GetsTypeIsNotDelete")]
        public IEnumerable<TypeResult> GetsTypeIsnotDelete()
        {
            return typeService.GetsTypeIsNotDelete();
        }
        [HttpGet]
        [Route("/Api/Type/GetsTypeIsDelete")]
        public IList<TypeResult> GetsTypeIsDelete()
        {
            return typeService.GetsTypeIsDelete();
        }
        [HttpGet]
        [Route("/Api/Type/GetTypeById")]
        public TypeResultById GetTypeById(int typeid)
        {
            return typeService.GetTypeById(typeid);
        }
        [HttpPost]
        [Route("/Api/Type/AddType")]
        public Messages AddType(AddType request)
        {
            return typeService.AddType(request);
        }

        [HttpPost]
        [Route("/Api/Type/DeleteType")]
        public Messages DeleteType(DeleteType request)
        {
            return typeService.DeleteType(request);
        }
        [HttpPost]
        [Route("/Api/Type/EditType")]
        public Messages EditType(EditType request)
        {
            return typeService.EditType(request);
        }
        [HttpPost]
        [Route("/Api/Type/RestoreType")]
        public Messages RestoreType(RestoreType request)
        {
            return typeService.RestoreType(request);
        }
    }
}
