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
    [Route("api/PROD_SERIALES")]
    [ApiController]
    public class PROD_SERIALESController : ControllerBase
    {
        APPDBContext control = new APPDBContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetR()
        {
            return control.PROD_SERIALES.OrderByDescending(x => x.FECHA).FirstOrDefault();
        }

        // GET api/values/5
        [HttpGet]
        [Route("getbySerial/{serial}")]
        public dynamic Get(string serial)
        {
            serial = System.Net.WebUtility.UrlDecode(serial);
            //string returnUrl = Server.UrlDecode(Request.QueryString["url"]);
            var s = control.PROD_SERIALES.Where(x => (x.SERIAL.Trim() == serial.Trim())).FirstOrDefault();
            
            return  s;
        } 

        
        //  [HttpPost]
        // [Route("ArraySeriales")]
        // public IActionResult Post([FromBody] PROD_SERIALES[] valor)
        // {

        //     void PrintEtiquetaBolsa(object sender, PrintPageEventArgs e){
          
        //     Pen pluma = new Pen(Color.Black,  1);

        //      string serial = valor[0].SERIAL,
        //                 // fecha = Convert.ToString(valor[0].FECHA),
        //                 revision = valor[0].REVISION,
        //                 qty = valor[0].QTY,
        //                 lote = valor[0].WO,
        //                 manufactureDate = Convert.ToString(valor[0].FECHA);
                   

        //            var Ejemplo = new BarcodeWriter();

        //            Ejemplo.Options.Margin = 0;
        //            Ejemplo.Format = BarcodeFormat.BarcodeFormat.CODE_39;
        //            Ejemplo.Options.Height = 30;
        //            Ejemplo.Options.PureBarcode = true;

            


        //             e.Graphics.DrawLine(pluma, 0, 100, 400, 100);
        //             e.Graphics.DrawLine(pluma, 0, 150, 400, 150);
        //             e.Graphics.DrawLine(pluma, 0, 200, 400, 200);
        //             e.Graphics.DrawLine(pluma, 0, 250, 400, 250);

        // }

         
        //   void imprimirEtiqueta(ulong cantetiquetas){

     
            

        //     var ip = "Adobe PDF";
            

        //     ulong totalEtiquetas = cantetiquetas;

        //     PrintDocument pd = new PrintDocument();
        //     pd.PrintPage += new PrintPageEventHandler(PrintEtiquetaBolsa);
        //     pd.DefaultPageSettings.PrinterSettings.PrinterName = ip;

        //     pd.DefaultPageSettings.PaperSize = new PaperSize("3x4", 400, 300);
        //     pd.DefaultPageSettings.Landscape = true;
        //     pd.Print();

        // }

                
        //     // try{
        //       control.PROD_SERIALES.AddRange(valor);
        //       control.SaveChanges();
        //       imprimirEtiqueta(1);
        //       return Ok();
        //     // }
        //     // catch(Exception e){
        //     //     Console.WriteLine(e);
        //     //     return Ok();
        //     // }

        // }

        

        // POST api/values
        [HttpPost]
        public string Post([FromBody] PROD_SERIALES value)
        {
              value.FECHA=DateTime.Now;  
              control.PROD_SERIALES.Add(value);
              control.SaveChanges();
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
 