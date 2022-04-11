using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data;
using Microsoft.EntityFrameworkCore;
using VISUAL7;

namespace MiApi.Controllers
{
    [Route("api/USER_DEF_FIELDS")]
    [ApiController]
    public class USER_DEF_FIELDSController : ControllerBase
    {
        MEGABASEContext intro = new MEGABASEContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetR()
        {
            return intro.USER_DEF_FIELDS.ToList();
        }

        // GET api/values/5
        // [HttpGet("{so}/{linea}")]
        // public dynamic GetR(string so)
        // {
            
            
        //     return intro.USER_DEF_FIELDS.Where(x => (x.SO == so)).ToList();     
        // }

        

        // POST api/values
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
            
        // }

          // PUT api/values/5
        
        [HttpPut("{so}/{linea}")]
        public USER_DEF_FIELDS Put( [FromBody] USER_DEF_FIELDS value)
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
 