using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using System.Text.Json;
using System.Text.Json.Serialization;
using APPDB;

namespace MiApi.Controllers
{
    [Route("api/G_NPI_CAMBIOS_STATUS")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        APPDBContext intro = new APPDBContext();
        // GET api/engineer
         [HttpGet]
        public dynamic Get()
        {
            return intro.G_NPI_CAMBIOS_STATUS.ToList();
        }

        // GET api/values/5
        [HttpGet("{so}/{line}")]
        public dynamic Get(string so, string line)
        {
            
            return intro.G_NPI_CAMBIOS_STATUS.Where(x => (x.SO == so) && (x.LINE == line)).ToList();     
        }

        

        // POST api/values
        [HttpPost]
        public string Post([FromBody] G_NPI_CAMBIOS_STATUS value)
        {
            intro.G_NPI_CAMBIOS_STATUS.Add(value);
            intro.SaveChanges();
            return "todobien";
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
 