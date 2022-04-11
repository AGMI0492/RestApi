using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VISUAL7;

namespace MiApi.Controllers
{
    [Route("api/G_VISTA_ENGINEERINGNPIP_DATOS")]
    [ApiController]
    
    public class VISUAL7VistaDatos : ControllerBase
    {
        MEGABASEContext intro = new MEGABASEContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetD()
        {
            
           
            
            return intro.G_VISTA_ENGINEERINGNPIP_DATOS.ToList();
        }
        // GET api/values/5
        [HttpGet("{part_id}/{drawing_rev_no}")]
        public dynamic GetD(string part_id, string drawing_rev_no)
        {
            
            
            var retorna = intro.G_VISTA_ENGINEERINGNPIP_DATOS.Where(x => (x.PART_ID == part_id) && (x.DRAWING_REV_NO == drawing_rev_no)).ToList();  
            return retorna;
        }

        

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

          // PUT api/values/5
        [HttpPut("{id}")]
        // public PICK_LIST Put(int id, [FromBody] PICK_LIST value)
        // {
        //     if(value.STATUS == "C")
        //     {
        //         value.DEL_DATE = DateTime.Now;
        //         MegaEntity.Entry(value).State = EntityState.Modified;
        //         MegaEntity.SaveChanges();
        //     }
        //     else
        //     {
        //         MegaEntity.Entry(value).State = EntityState.Modified;
        //         MegaEntity.SaveChanges();
        //     }
        //     return value;
        // }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    
}
 