using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VISUAL7;


namespace MiApi.Controllers
{
    [Route("api/G_NPI_ENGINEERING_INFOTABLE")]
    [ApiController]
    
    public class Visual7Info : ControllerBase
    {
        MEGABASEContext intro = new MEGABASEContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetI()
        {
            

            return intro.G_NPI_ENGINEERING_INFOTABLE.ToList();
        }

        // GET api/values/5
        [HttpGet("{rowid}")]
        public dynamic GetU(int rowid)
        {
            
            
            var retorna = intro.G_NPI_ENGINEERING_INFOTABLE.Where(x => (x.ROWID == rowid)).ToList();  
            return retorna;
        }

        

        // POST api/values
        [HttpPost]
        public string Post([FromBody] G_NPI_ENGINEERING_INFOTABLE value)
        {
    
            intro.G_NPI_ENGINEERING_INFOTABLE.Add(value);
            intro.SaveChanges();
            return "todobien";
   
            
        }

          // PUT api/values/5
        [HttpPut("{rowid}")]
        public G_NPI_ENGINEERING_INFOTABLE Put( [FromBody] G_NPI_ENGINEERING_INFOTABLE value)
        {
                
                intro.Entry(value).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
 