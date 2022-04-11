using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VISUAL7;


namespace MiApi.Controllers
{
    [Route("api/G_VISTA_NPI_DASHBOARDWO")]
    [ApiController]
    
    public class Visual7WO : ControllerBase
    {
        MEGABASEContext intro = new MEGABASEContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetI()
        {
            

            return intro.G_VISTA_NPI_DASHBOARDWO.ToList();
        }

        // GET api/values/5
        [HttpGet("{wo_id}/{so_id}/{line_id}")]
        public dynamic GetU(string wo_id, string so_id, string line_id)
        {
            
            
            var retorna = intro.G_VISTA_NPI_DASHBOARDWO.Where(x => (x.WORKORDER_BASE_ID == wo_id) && (x.so == so_id) &&  (x.line == line_id)).ToList();  

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
 