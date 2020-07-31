using Microsoft.AspNetCore.Mvc;
using Mp3WebMusic.BAL.INTERFACE;
using Mp3WebMusic.DOMAIN.Reponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mp3WebMusic.API.Controllers
{
    public class TypeController : Controller
        //minhdeptrai1234
        //Tín 
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
