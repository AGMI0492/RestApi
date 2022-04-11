using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NOMINA10;

namespace MiApi.Controllers
{
    [Route("api/VW_PYEM_EMPLEADOSACTIVOS")]
    [ApiController]
    public class VW_PYEM_EMPLEADOSACTIVOSController : ControllerBase
    {
       NOMINA10Context EMPACTIVOS = new NOMINA10Context();
        // GET api/engineer
         [HttpGet]
        public dynamic GetR()
        {
            return EMPACTIVOS.VW_PYEM_EMPLEADOSACTIVOS.ToList();
        }

        // GET api/values/5
        [HttpGet("{emp}")]
        public dynamic GetR(string emp)
        {
            
            
            return EMPACTIVOS.VW_PYEM_EMPLEADOSACTIVOS.Where(x => (x.EMPLEADO == emp)).ToList();     
        }

        //  [HttpGet("{tipo}/{calibre}")]
        // public dynamic GetD(string tipo, string calibre)
        // {
            
            
        //     return EMPACTIVOS.VW_PYEM_EMPLEADOSACTIVOS.Where(x => (x.TIPO == tipo) && (x.CALIBRE == calibre)).ToList();     
        // }
        

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
 