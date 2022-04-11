using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APPDB;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;



namespace MiApi.Controllers
{
    
    [Route("api/grapadoA")]
    [ApiController]
    public class grapadoAjustadores : ControllerBase
    {
        APPDBContext intro = new APPDBContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetR()
        {
            return intro.AJUSTADORES_GRAPADO.ToList();
        }

        

        // GET api/values/5
        [HttpGet("{rowid}")]
        public dynamic GetD(int rowid)
        {
            
            
            return intro.AJUSTADORES_GRAPADO.Where(x => (x.ROWID == rowid)).ToList();     
        }




        //  [HttpGet("{tipo}/{calibre}")]
        // public dynamic GetD(string tipo, string calibre)
        // {
            
            
        //     return Terminal.Grapado_Terminal.Where(x => (x.TIPO == tipo) && (x.CALIBRE == calibre)).ToList();     
        // }
        

        // POST api/values
        [HttpPost]
        public string Post([FromBody] AJUSTADORES_GRAPADO value)
        {
            intro.AJUSTADORES_GRAPADO.Add(value);
            intro.SaveChanges();
            return "todobien";
        }

       
             [HttpPut("{rowid}")]
        public AJUSTADORES_GRAPADO Put( [FromBody] AJUSTADORES_GRAPADO value)
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
 