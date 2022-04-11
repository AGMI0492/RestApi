using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VISUAL7;
using Microsoft.EntityFrameworkCore;

namespace MiApi.Controllers
{
    [Route("api/G_NPI_ENGINEERINGNPIP")]
    [ApiController]
    
    public class ENGNPIP : ControllerBase
    {
        MEGABASEContext intro = new MEGABASEContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetU()
        {
            

            return intro.G_NPI_ENGINEERINGNPIP.ToList();
        }


        // GET api/values/5
        [HttpGet("{part_id}/{rev}")]
        public dynamic GetU(string part_id, string rev)
        {
            
            
            var retorna = intro.G_NPI_ENGINEERINGNPIP.Where(x => (x.PART_ID == part_id) && (x.REV_DRAWING_NO == rev)).ToList();  
            return retorna;
        }

        

        // POST api/values
        [HttpPost]
        public string Post([FromBody] G_NPI_ENGINEERINGNPIP value)
        {
            //insert
           intro.G_NPI_ENGINEERINGNPIP.Add(value);
           intro.SaveChanges();

            //update    
            // intro.Entry(value).State = EntityState.Modified;
            // intro.SaveChanges();
            return "todomal";
            
        }

          // PUT api/values/5
        [HttpPut("{rowid}")]
     public G_NPI_ENGINEERINGNPIP Put( [FromBody] G_NPI_ENGINEERINGNPIP value)
        {
           
               
                intro.Entry(value).State = EntityState.Modified;
                intro.SaveChanges();
            
            return value;
        }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    
}
 