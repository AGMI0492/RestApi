using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VISUAL7;


namespace MiApi.Controllers
{
    [Route("api/PART")]
    [ApiController]
    
    public class PartInfo : ControllerBase
    {
        MEGABASEContext intro = new MEGABASEContext();
        // GET api/engineer
         [HttpGet]
        public dynamic Get()
        {
            

            return intro.PART.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public dynamic Get(string id)
        {
            
            
            var retorna = intro.PART.Where(x => (x.ID == id)).ToList();  
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
 