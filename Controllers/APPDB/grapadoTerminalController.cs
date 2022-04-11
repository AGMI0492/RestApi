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
    [Route("api/grapadoT")]
    [ApiController]
    public class grapadoTerminal : ControllerBase
    {
        APPDBContext Terminal = new APPDBContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetR()
        {
            return Terminal.Grapado_Terminal.ToList();

            
        }

        [HttpGet]
        public dynamic GetIP(){ 

          var ipAdd = Request.HttpContext.Connection.RemoteIpAddress;

          return ipAdd;

        }

        

        // GET api/values/5
        [HttpGet("{wo}")]
        public dynamic GetR(string wo)
        {
            
            
            return Terminal.Grapado_Terminal.Where(x => (x.WO == wo)).ToList();     
        }

        //  [HttpGet("{tipo}/{calibre}")]
        // public dynamic GetD(string tipo, string calibre)
        // {
            
            
        //     return Terminal.Grapado_Terminal.Where(x => (x.TIPO == tipo) && (x.CALIBRE == calibre)).ToList();     
        // }
        

        // POST api/values
        [HttpPost]
        public string Post([FromBody] Grapado_Terminal value)
        {
            Terminal.Grapado_Terminal.Add(value);
            Terminal.SaveChanges();
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
 