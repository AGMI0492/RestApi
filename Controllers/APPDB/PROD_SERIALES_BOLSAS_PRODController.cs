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
    [Route("api/PROD_SERIALES_BOLSAS_PROD")]
    [ApiController]
    public class PROD_SERIALES_BOLSAS_PRODController : ControllerBase
    {

        
        APPDBContext prod = new APPDBContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetR()
        {
            return prod.PROD_SERIALES_BOLSAS_PROD.OrderByDescending(x => x.FECHA).FirstOrDefault();
        }

        // GET api/values/5
        // [HttpGet("{serial}")]
        // public dynamic Get(string serial)
        // {
        //     serial = System.Net.WebUtility.UrlDecode(serial);
        //     //string returnUrl = Server.UrlDecode(Request.QueryString["url"]);
        //     var s = prod.PROD_SERIALES_BOLSAS_PROD.Where(x => (x.FOLIO_CAJA.Trim() == serial.Trim())).FirstOrDefault();
            
        //     return  s;
        // } 

      [HttpGet("{serial_bolsa}")]
        public dynamic GetS(string serial_bolsa)
        {
            serial_bolsa = System.Net.WebUtility.UrlDecode(serial_bolsa);
            return prod.PROD_SERIALES_BOLSAS_PROD.OrderByDescending(x => (x.ID == serial_bolsa)).FirstOrDefault();
            
        }


    //    [HttpPost]
    //     public string  Post([FromBody] PROD_SERIALES_BOLSAS_PROD value)
    //     {

    //         void PrintEtiquetaBolsa(object sender, PrintPageEventArgs e){
          
    //         Pen pluma = new Pen(Color.Black,  1);

    //          string serial = valor[0].ENSAMBLE,
    //                     // fecha = Convert.ToString(valor[0].FECHA),
    //                     revision = valor[0].REVISION,
    //                     qty = valor[0].QTY,
    //                     lote = valor[0].WO,
    //                     descripcion = valor[0].DESCRIPCION,
    //                     manufactureDate = DateTime.Today.ToString("MMddyyyy");
                        
                   
                  
    //                var Ejemplo = new BarcodeWriter();

    //                Ejemplo.Options.Margin = 0;
    //                Ejemplo.Format = BarcodeFormat.BarcodeFormat.CODE_39;
    //                Ejemplo.Options.Height = 30;
    //                Ejemplo.Options.PureBarcode = true;

    //                 ulong numeroSerie = Convert.ToUInt32(control.contadores.Where(x => (x.idContador == "GTX")).FirstOrDefault().contador);

    //                 e.Graphics.DrawLine(pluma, 0, 100, 400, 100);
    //                 e.Graphics.DrawLine(pluma, 0, 150, 400, 150);
    //                 e.Graphics.DrawLine(pluma, 0, 200, 400, 200);
    //                 e.Graphics.DrawLine(pluma, 0, 250, 400, 250);

    //                 // Headers
    //                 e.Graphics.DrawString("PART NUMBER (P)", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 10, 5);
    //                 e.Graphics.DrawString("SERIAL (S)", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 310, 5);
    //                 e.Graphics.DrawString("REVISION (2P)", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 10, 105);
    //                 e.Graphics.DrawString("QUANTITY (Q)", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 10, 155);
    //                 e.Graphics.DrawString("MANUFACTURE DATE (M)", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 10, 205);
    //                 e.Graphics.DrawString("SUPPLIER/VENDOR", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 10, 255);
    //                 e.Graphics.DrawString("LOT NUMBER", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 260, 262);

    //                 //CONTENIDO
    //                 e.Graphics.DrawString(serial, new Font("Arial", 25), new SolidBrush(Color.Black), 5, 15);
    //                 e.Graphics.DrawString(Base36.Base36Encode(numeroSerie, "XTG").ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), 280, 15);
    //                 e.Graphics.DrawString(descripcion, new Font("Arial", 10), new SolidBrush(Color.Black), 10, 85);
    //                 e.Graphics.DrawString(revision, new Font("Arial", 20), new SolidBrush(Color.Black), 210, 110);
    //                 e.Graphics.DrawString(qty, new Font("Arial", 20), new SolidBrush(Color.Black), 210, 160);
    //                 e.Graphics.DrawString(manufactureDate, new Font("Arial", 20), new SolidBrush(Color.Black), 210, 210);
    //                 e.Graphics.DrawString("MEGA TECHWAY INC.", new Font("Arial", 15, FontStyle.Bold), new SolidBrush(Color.Black), 5, 265);
    //                 e.Graphics.DrawString(lote, new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), 260, 270);

    //                 //CODIGOS DE BARRAS

    //                 e.Graphics.DrawImage(Ejemplo.Write("P" + serial), 10, 50);
    //                 e.Graphics.DrawImage(Ejemplo.Write("2P" + revision), 10, 117);
    //                 e.Graphics.DrawImage(Ejemplo.Write("Q" + qty), 10, 167);
    //                 e.Graphics.DrawImage(Ejemplo.Write("M" + manufactureDate), 10, 217);

                    

    //                 // e.HasMorePages = true;

                
    //                 // e.HasMorePages = false;

    //     }

         
    //       void imprimirEtiqueta(ulong cantetiquetas){

     
            

    //         var ip = "Adobe PDF";
            

    //         ulong totalEtiquetas = cantetiquetas;

    //         PrintDocument pd = new PrintDocument();
    //         pd.PrintPage += new PrintPageEventHandler(PrintEtiquetaBolsa);
    //         pd.DefaultPageSettings.PrinterSettings.PrinterName = ip;

    //         // pd.DefaultPageSettings.PaperSize = new PaperSize("3x4", 400, 300);
    //         pd.DefaultPageSettings.PaperSize = new PaperSize("4x3", 300, 400);

    //         pd.DefaultPageSettings.Landscape = true;
    //         pd.Print();

    //     }
              
    //           value.FECHA=DateTime.Now;  
    //           prod.PROD_SERIALES_BOLSAS_PROD.Add(value);
    //           prod.SaveChanges();
    //           imprimirEtiqueta(1);
    //           return "todobien";
              


    //     }
        
        

        // POST api/values

        [HttpPost]
        [Route("PostAddFolio")]
        public IActionResult Post([FromBody] PROD_SERIALES_BOLSAS_PROD[] valor)
        {
                
            try{
              prod.PROD_SERIALES_BOLSAS_PROD.AddRange(valor);
              prod.SaveChanges();
              return Ok();
            }
            catch(Exception e){
                Console.WriteLine(e);
                return Ok();
            }

        }

//

        // public static void imprimirEtiqueta(ulong cantetiquetas){
        //     ulong totalEtiquetas = cantetiquetas;

        //     PrintDocument pd = new PrintDocument();
        //     pd.PrintPage += new PrintPageEventHandler(printSandorETQ);
        //     pd.DefaultPageSettings.PrinterSettings.PrinterName = "Adobe PDF";
        //     pd.DefaultPageSettings.PaperSize = new PaperSize("3x4", 400, 300);
        //     pd.DefaultPageSettings.Landscape = true;
        //     pd.Print();

        // }


        // public static void printSandorETQ(object sender, PrintPageEventArgs e){

        //     Pen pluma = new Pen(Color.Black,  1);

        //     string wo = "22HH345712",
        //            serial = "D1",
        //            validate = "Validado";

        //            var Ejemplo = new BarcodeWriter();

        //            Ejemplo.Options.Margin = 0;
        //            Ejemplo.Format = BarcodeFormat.BarcodeFormat.CODE_128;
        //            Ejemplo.Options.Height = 40;
        //            Ejemplo.Options.PureBarcode = true;

        //            var DataMatrix = new BarcodeWriter();
        //            DataMatrix.Format = BarcodeFormat.BarcodeFormat.DATA_MATRIX;
        //         //    DataMatrix.Options.Width = 10;
        //            DataMatrix.Options.Height = 20;


        //            e.Graphics.DrawString(wo, new Font("Arial",12,FontStyle.Bold), new SolidBrush(Color.Black),5,10);
                   
        //            e.Graphics.DrawString(serial, new Font("Arial",12,FontStyle.Bold),new SolidBrush(Color.Black),5,30);
        //         //    e.Graphics.DrawImage(Ejemplo.Write(rev), 15, 150);

        //         //    e.Graphics.DrawImage(DataMatrix.Write(part+" "+rev),1, 125);

        //            e.Graphics.DrawString(validate, new Font("Arial",12,FontStyle.Bold), new SolidBrush(Color.Black),5, 50);


        // }

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
 