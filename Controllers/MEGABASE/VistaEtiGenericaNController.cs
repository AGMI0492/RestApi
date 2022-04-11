using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
// using Microsoft.AspNetCore.Cors;
using VISUAL7;



namespace MiApi.Controllers
{
  
//   [EnableCors("AllowSpecific")]
    [Route("api/VistaEtiGenericaN")]
    [ApiController]
    
    public class VistaEtiGenericaN : ControllerBase
    {
        MEGABASEContext intro = new MEGABASEContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetD()
        {
            
           
            
            return intro.VistaEtiGenericaN.ToList();
        }
       
              // GET api/values/5
        [HttpGet("{wo}")]
        public dynamic GetD(string wo)
        {
            
            
            return (intro.VistaEtiGenericaN.Where(x => (x.WO == wo))).ToList();  
            // return retorna;
        }
        
        

        // POST api/values
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
            
        // }

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
 