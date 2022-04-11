using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VISUAL7;


namespace MiApi.Controllers
{
    [Route("api/G_NPI_NPIPS")]
    [ApiController]
    
    public class npiPsInfo : ControllerBase
    {
        MEGABASEContext intro = new MEGABASEContext();
        // GET api/engineer
         [HttpGet]
        public dynamic Get()
        {
            

            return intro.G_NPI_NPIPS.ToList();
        }

        // GET api/values/5
        // [HttpGet("{id}")]
        // public dynamic Get(int id)
        // {
            
            
        //     var retorna = intro.G_NPI_NPIPS.Where(x => (x.ROWID == id)).ToList();  
        //     return retorna;
        // }

       [HttpGet("{part_id}")]
        public dynamic Get(string part_id)
        {
            
            
          var retorna=  intro.G_NPI_NPIPS.Where(x => (x.PART_ID == part_id)).ToList();  
          return retorna;
        }

        

        // POST api/values
        [HttpPost]
        public void Post([FromBody] G_NPI_NPIPS value)
        {
             intro.G_NPI_NPIPS.Add(value);
             intro.SaveChanges();
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
 