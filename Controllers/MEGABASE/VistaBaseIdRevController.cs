using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VISUAL7;


namespace MiApi.Controllers
{
    [Route("api/G_VISTA_ENGINEERINGNPIP_BASEID_DRAWINGREVNO")]
    [ApiController]
    
    public class partrev : ControllerBase
    {
        MEGABASEContext intro = new MEGABASEContext();
        // GET api/engineer
         [HttpGet]
        public dynamic Get()
        {
            

            return intro.G_VISTA_ENGINEERINGNPIP_BASEID_DRAWINGREVNO.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}/{rev}")]
        public dynamic Get(string id, string rev)
        {
            
            
            var retorna = intro.G_VISTA_ENGINEERINGNPIP_BASEID_DRAWINGREVNO.Where(x => (x.ID == id) && (x.DRAWING_REV_NO == rev)).ToList();  
            return retorna;
        }

       
        

        

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

          // PUT api/values/5
        //[HttpPut("{id}")]
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
 