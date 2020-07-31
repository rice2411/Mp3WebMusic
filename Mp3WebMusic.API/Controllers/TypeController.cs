using Microsoft.AspNetCore.Mvc;
using Mp3WebMusic.BAL.INTERFACE.Types;
using Mp3WebMusic.DOMAIN.Reponse.Types;
using System.Collections.Generic;

namespace Mp3WebMusic.API.Controllers
{
    public class TypeController : Controller
        //minhdeptrai1234
        //12h
        //Tín 
        //ancom
        // ve thoai
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
            return typeService.GetsTypeIsnotDelete();
        }
       
    }
}
