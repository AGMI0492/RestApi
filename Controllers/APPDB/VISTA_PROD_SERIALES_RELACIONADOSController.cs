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
    [Route("api/VISTA_PROD_SERIALES_RELACIONADOS")]
    [ApiController]
    public class VISTA_PROD_SERIALES_RELACIONADOSController : ControllerBase
    {


        APPDBContext control = new APPDBContext();
        // GET api/engineer
       
       

        [HttpGet("{folio}/{program_type}")]
        public dynamic GetobtF(string folio, string program_type)
        {
            // serial = System.Net.WebUtility.UrlDecode(serial);
            //string returnUrl = Server.UrlDecode(Request.QueryString["url"]);
            var p = control.PROD_SERIALES_DYNALAB.Where(x => (x.FOLIO == folio) && (x.PROGRAM_TYPE == program_type)).ToList();

            return p;
        }



        // [HttpPost]
        // public string Post([FromBody] PROD_SERIALES_DYNALAB value)
        // {

        //     void printSandorETQ(object sender, PrintPageEventArgs e)
        //     {

        //         Pen pluma = new Pen(Color.Black, 1);

        //         string wo = value.WO,
        //                serial = value.SERIAL,
        //                validate = "Validado";


        //         var Ejemplo = new BarcodeWriter();

        //         Ejemplo.Options.Margin = 0;
        //         Ejemplo.Format = BarcodeFormat.BarcodeFormat.CODE_128;
        //         Ejemplo.Options.Height = 40;
        //         Ejemplo.Options.PureBarcode = true;

        //         var DataMatrix = new BarcodeWriter();
        //         DataMatrix.Format = BarcodeFormat.BarcodeFormat.DATA_MATRIX;
        //         DataMatrix.Options.Height = 20;

        //         // Rectangle rec1 = new Rectangle(5, 30, 190, 65);


        //         e.Graphics.DrawString(wo, new Font("Arial", 12, FontStyle.Bold), new SolidBrush(Color.Black), 5, 10);

        //         e.Graphics.DrawString(serial, new Font("Arial", 12, FontStyle.Bold), new SolidBrush(Color.Black), 5, 30);

        //         e.Graphics.DrawString(validate, new Font("Arial", 12, FontStyle.Bold), new SolidBrush(Color.Black), 5, 50);
        //     }

        //     void imprimirEtiqueta(ulong cantetiquetas)
        //     {

        


        //         var ip = value.IP_ADDRESS;


        //         ulong totalEtiquetas = cantetiquetas;

        //         PrintDocument pd = new PrintDocument();
        //         pd.PrintPage += new PrintPageEventHandler(printSandorETQ);
        //         pd.DefaultPageSettings.PrinterSettings.PrinterName = ip;

        //         pd.DefaultPageSettings.PaperSize = new PaperSize("3x4", 400, 300);
        //         pd.DefaultPageSettings.Landscape = true;
        //         pd.Print();

        //     }

        //     value.PRINTED_DATE = DateTime.Now;
        //     control.PROD_SERIALES_DYNALAB.Add(value);
        //     control.SaveChanges();
        //     imprimirEtiqueta(1);
        //     return "todobien";



        // }



        // POST api/values

        // [HttpPost]
        // [Route("PostAddFolio")]
        // public IActionResult Post([FromBody] PROD_SERIALES_DYNALAB[] valor)
        // {

        //     try
        //     {
        //         control.PROD_SERIALES_DYNALAB.AddRange(valor);
        //         control.SaveChanges();
        //         return Ok();
        //     }
        //     catch (Exception e)
        //     {
        //         Console.WriteLine(e);
        //         return Ok();
        //     }

        // }

        //

        

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


        //   [HttpDelete("{rowid}")] // api/autores/2
        // public async Task<ActionResult> Delete(int rowid)
        // {
        //     var existe = control.PROD_SERIALES_DYNALAB.Where(x => (x.ROWID == rowid)).ToList();

        //     if (existe == null)
        //     {
        //         return NotFound();
        //     }

        //     control.Remove(existe);
        //     await control.SaveChangesAsync();
        //     return Ok();
        // } 
    
}

}
