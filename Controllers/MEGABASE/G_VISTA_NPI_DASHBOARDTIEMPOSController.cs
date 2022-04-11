using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VISUAL7;


namespace MiApi.Controllers
{
    [Route("api/G_VISTA_NPI_DASHBOARDTIEMPOS")]
    [ApiController]
    
    public class Visual7Tiempos : ControllerBase
    {
        MEGABASEContext intro = new MEGABASEContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetI()
        {
            

            return intro.G_VISTA_NPI_DASHBOARDTIEMPOS.ToList();
        }

        // GET api/values/5
        [HttpGet("{part_id}/{rev}/{so2}/{line}")]
        public dynamic GetU(string part_id, string rev, string so2, string line)
        {
            
            
            var retorna = intro.G_VISTA_NPI_DASHBOARDTIEMPOS.Where(x => (x.PART_ID
            == part_id) && (x.DRAWING_REV_NO == rev) && (x.SO2 == so2) && (x.LINE == line)).ToList();  

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
 