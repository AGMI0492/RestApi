using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data;
using Microsoft.EntityFrameworkCore;
using APPDB;

namespace MiApi.Controllers
{
    [Route("api/G_NPIP_RASTREO")]
    [ApiController]
    public class RastreoController : ControllerBase
    {
        APPDBContext rastreo = new APPDBContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetR()
        {
            return rastreo.G_NPIP_RASTREO.ToList();
        }

        // GET api/values/5
        [HttpGet("{so}/{linea}")]
        public dynamic GetR(string so)
        {
            
            
            return rastreo.G_NPIP_RASTREO.Where(x => (x.SO == so)).ToList();     
        }

        

        // POST api/values
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
            
        // }

          // PUT api/values/5
        
        [HttpPut("{so}/{linea}")]
        public G_NPIP_RASTREO Put( [FromBody] G_NPIP_RASTREO value)
        {
                
                rastreo.Entry(value).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                rastreo.SaveChanges();
            
            return value;
        }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    
}
 