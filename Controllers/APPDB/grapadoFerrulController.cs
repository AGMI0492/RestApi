using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APPDB;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MiApi.Controllers
{
    [Route("api/grapadoF")]
    [ApiController]
    public class grapadoFerrul : ControllerBase
    {
        APPDBContext Ferrul = new APPDBContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetR()
        {
            return Ferrul.Grapado_Ferrul.ToList();
        }

        // GET api/values/5
        // [HttpGet("{tipo}")]
        // public dynamic GetR(string tipo)
        // {
            
            
        //     return Terminal.Grapado_Terminal.Where(x => (x.TIPO == tipo)).ToList();     
        // }

        //  [HttpGet("{tipo}/{calibre}")]
        // public dynamic GetD(string tipo, string calibre)
        // {
            
            
        //     return Terminal.Grapado_Terminal.Where(x => (x.TIPO == tipo) && (x.CALIBRE == calibre)).ToList();     
        // }
        

        // POST api/values
        [HttpPost]
        public string Post([FromBody] Grapado_Ferrul value)
        {
            Ferrul.Grapado_Ferrul.Add(value);
            Ferrul.SaveChanges();
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
 