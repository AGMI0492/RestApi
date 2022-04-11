using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
// using APPDB;

namespace APPDB
{
    [Route("api/rastreo")]
    [ApiController]
    
    public class rastreo : ControllerBase
    {
        APPDBContext rt = new APPDBContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GETR()
        {
            

            return rt.G_NPIP_RASTREO.ToList();
        }

        // GET api/values/5
        [HttpGet("{so}/{line}")]
        public dynamic GetU(string so, int line)
        {
            
            
            var retorna = rt.G_NPIP_RASTREO.Where(x => (x.SO == so) && (x.LINEA == line)).ToList();  
            return retorna;
        }

        

    //    [HttpPost]
    //     public string Post([FromBody] G_NPIP_RASTREO value)
    //     {
    //         rt.G_NPIP_RASTREO.Add(value);
    //         rt.SaveChanges();
    //         return "todobien";
    //     }

       
             [HttpPut("{rowid}")]
        public G_NPIP_RASTREO Put( [FromBody] G_NPIP_RASTREO value)
        {
           
               
                rt.Entry(value).State = EntityState.Modified;
                rt.SaveChanges();
            
            return value;
        }



        // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
    
}
 