using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using APPDB;


namespace MiApi.Controllers
{
    
    [Route("api/maquinasSemi")]
    [ApiController]
    public class PROD_MAQUINAS_CORTESEMIAUTOController : ControllerBase
    {
        APPDBContext intro = new APPDBContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetR()
        {
            return intro.PROD_MAQUINAS_CORTESEMIAUTO.ToList();
        }

        

        // GET api/values/5
        [HttpGet("{rowid}")]
        public dynamic GetD(int rowid)
        {
            
            
            return intro.PROD_MAQUINAS_CORTESEMIAUTO.Where(x => (x.ROWID == rowid)).ToList();     
        }




        //  [HttpGet("{tipo}/{calibre}")]
        // public dynamic GetD(string tipo, string calibre)
        // {
            
            
        //     return Terminal.Grapado_Terminal.Where(x => (x.TIPO == tipo) && (x.CALIBRE == calibre)).ToList();     
        // }
        

        // POST api/values
        // [HttpPost]
        // public string Post([FromBody] MAQUINAS_SEMIAUTOMATICO valor)
        // {
        //     intro.MAQUINAS_SEMIAUTOMATICO.Add(valor);
        //     intro.SaveChanges();
        //     return "todobien";
        // }

         [HttpPost]
        //    [Route("datos")]
        public string Post([FromBody] PROD_MAQUINAS_CORTESEMIAUTO value)
        {
              value.FECHA=DateTime.Now;  
              intro.PROD_MAQUINAS_CORTESEMIAUTO.AddRange(value);
              intro.SaveChanges();
              return "todobien";
        }
       
        //      [HttpPut("{rowid}")]
        // public MAQUINAS_SEMIAUTOMATICO Put( [FromBody] MAQUINAS_SEMIAUTOMATICO value)
        // {
           
               
        //         intro.Entry(value).State = EntityState.Modified;
        //         intro.SaveChanges();
            
        //     return value;
        // }

        


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    
}
 