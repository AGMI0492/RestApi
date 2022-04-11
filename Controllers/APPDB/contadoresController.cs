using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APPDB;

namespace MiApi.Controllers
{
    [Route("api/contadores")]
    [ApiController]
    public class contadoresController : ControllerBase
    {
        APPDBContext AppDBContadores = new APPDBContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetR()
        {
            return AppDBContadores.contadores.ToList();
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public dynamic GetE(string id)
        {
            
            
            return AppDBContadores.contadores.Where(x => (x.idContador == id)).ToList();     
            
        }

        
    }
    
}
 