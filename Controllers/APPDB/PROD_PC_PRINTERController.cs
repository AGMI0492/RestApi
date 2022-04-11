using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Drawing;
using System.Drawing.Printing;
using ZXing.Windows.Compatibility;
using BarcodeFormat = ZXing;
using ZXing.Datamatrix.Encoder;
using APPDB;

namespace MiApi.Controllers
{
    [Route("api/PROD_PC_PRINTER")]
    [ApiController]
    public class PROD_PC_PRINTERController : ControllerBase
    {

        
        APPDBContext control = new APPDBContext();
        // GET api/engineer
         [HttpGet("{printer}")]
        public dynamic GetR(string printer)
        {
        var remoteIpAddress = HttpContext.Connection.RemoteIpAddress;

            return control.PROD_PC_PRINTER.Where(x => x.IP_ADDRESS == printer).ToList();
        }

        // [HttpGet]
        // public dynamic GetR()
        // {
        //     return control.PROD_PC_PRINTER.ToList();
            
        // }

         [HttpGet]
        public dynamic GetF()
        {
             var remoteIpAddress = HttpContext.Connection.RemoteIpAddress;
             var todomal = remoteIpAddress.ToString();
             var Json = JsonSerializer.Serialize(todomal);
             return Json;
             
            

            
        }



        // GET api/values/5
        // [HttpGet]
        // [Route("getbySerial/{serial}")]
        // public dynamic Get(string serial)
        // {
        //     serial = System.Net.WebUtility.UrlDecode(serial);
        //     //string returnUrl = Server.UrlDecode(Request.QueryString["url"]);
        //     var s = control.PROD_PC_PRINTER.Where(x => (x.SERIAL.Trim() == serial.Trim())).FirstOrDefault();
            
        //     return  s;
        // } 

        
        

        // POST api/values
        


       

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
 