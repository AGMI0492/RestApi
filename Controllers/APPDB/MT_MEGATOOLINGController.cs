using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using APPDB;

namespace MiApi.Controllers
{
    [Route("api/MT_MEGATOOLING")]
    [ApiController]
    public class MT_MEGATOOLINGController : ControllerBase
    {
        APPDBContext mt_MegaTooling = new APPDBContext();
        // GET api/engineer
         [HttpGet]
        public ActionResult GetR()
        {
            return Ok(mt_MegaTooling.MT_MEGATOOLING.ToList());
               

        }

        // GET api/values/5
        [HttpGet("{terminal}/{calibre}")]
        public dynamic GetR(string terminal, string calibre)
        {
            
            
            return mt_MegaTooling.MT_MEGATOOLING.Where(x => (x.TERMINAL_PART_NUMBER == terminal ) && (x.AWG == calibre)).ToList();     
        }

         [HttpGet("{numero}/{terminal}/{calibre}")]
        public dynamic GetD(string numero, string terminal, string calibre)
        {
            
            
            return mt_MegaTooling.MT_MEGATOOLING.Where(x => (x.MT == numero) && (x.TERMINAL_PART_NUMBER == terminal) && (x.AWG == calibre)).ToList();     
        }
        

        // POST api/values
        [HttpPost]
         public string Post([FromBody] MT_MEGATOOLING value)
        {
              
              mt_MegaTooling.MT_MEGATOOLING.Add(value);
              mt_MegaTooling.SaveChanges();
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
 