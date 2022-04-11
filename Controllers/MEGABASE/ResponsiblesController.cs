using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VISUAL7;

namespace MiApi.Controllers
{
    [Route("api/G_NPI_ENGINEERINGNPIP_RESPONSIBLES")]
    [ApiController]
    
    public class VISUAL7Responsibles : ControllerBase
    {
        MEGABASEContext intro = new MEGABASEContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetU()
        {
            

            return intro.G_NPI_ENGINEERINGNPIP_RESPONSIBLES.ToList();
        }

        // GET api/values/5
        [HttpGet("{npip_no}")]
        public dynamic GetU(string npip_no)
        {
            
            
            var retorna = intro.G_NPI_ENGINEERINGNPIP_RESPONSIBLES.Where(x => (x.NPIP_NO == npip_no)).ToList();  
            return retorna;
        }

        

        // POST api/values
        [HttpPost]
        public string Post([FromBody] G_NPI_ENGINEERINGNPIP_RESPONSIBLES value)
        {
            intro.G_NPI_ENGINEERINGNPIP_RESPONSIBLES.Add(value);
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
 