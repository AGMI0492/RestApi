using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using System.Text;
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
    [Route("api/PROD_SERIALES_PRUEBAS")]
    [ApiController]
    public class PROD_SERIALES_PRUEBASController : ControllerBase
    {
        APPDBContext control = new APPDBContext();
        // GET api/engineer
         [HttpGet]
        public dynamic GetR()
        {
            return control.PROD_SERIALES_PRUEBAS.OrderByDescending(x => x.FECHA).FirstOrDefault();
        }

        // GET api/values/5
        [HttpGet]
        [Route("getbySerial/{serial}")]
        public dynamic Get(string serial)
        {
            serial = System.Net.WebUtility.UrlDecode(serial);
            //string returnUrl = Server.UrlDecode(Request.QueryString["url"]);
            var s = control.PROD_SERIALES_PRUEBAS.Where(x => (x.SERIAL.Trim() == serial.Trim())).FirstOrDefault();
            
            return  s;
        } 

          [HttpGet]
        [Route("getbyId/{id_bolsa}")]
        public dynamic GetX(string id_bolsa)
        {
            id_bolsa = System.Net.WebUtility.UrlDecode(id_bolsa);
            //string returnUrl = Server.UrlDecode(Request.QueryString["url"]);
            var s = control.PROD_SERIALES_PRUEBAS.Where(x => (x.ID_BOLSA.Trim() == id_bolsa.Trim())).FirstOrDefault();
            
            return  s;
        } 


        

      public class Base36{
           private const string Clist = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static readonly char[] Clistarr = Clist.ToCharArray();

            
        public static string Base36Encode(ulong inputNumber, string locacion)
        {
            var sb = new StringBuilder();
            do
            {
                sb.Append(Clistarr[inputNumber % (ulong)Clist.Length]);
                inputNumber = inputNumber / (ulong)Clist.Length;
            }

            while (inputNumber != 0);

            for (int i = sb.Length; i < 7; i++)
            {
                sb.Append("0");
            }

            sb.Append(locacion);

            var valorfinal = sb.ToString().ToCharArray();
            Array.Reverse(valorfinal);
            return new string(valorfinal);
        }
    }


        
         [HttpPost("Arrays")]
        //[Route("Arrays")]
        public IActionResult Post([FromBody] PROD_SERIALES_PRUEBAS[] valor)
        {

               

            void PrintEtiquetaBolsa(object sender, PrintPageEventArgs e){
          
            Pen pluma = new Pen(Color.Black,  1);

            

             string serial = valor[0].ENSAMBLE,
                        // fecha = Convert.ToString(valor[0].FECHA),
                        revision = valor[0].REVISION,
                        lote = valor[0].WO,
                        description = valor[0].DESCRIPCION,
                        manufactureDate = DateTime.Today.ToString("MM/dd/yyyy"),
                        qty = valor.Count(x=>x!=null).ToString();
                   
                  
                   var Ejemplo = new BarcodeWriter();

                   Ejemplo.Options.Margin = 0;
                   Ejemplo.Format = BarcodeFormat.BarcodeFormat.CODE_39;
                   Ejemplo.Options.Height = 25;
                   Ejemplo.Options.PureBarcode = true;
                    


                      e.Graphics.DrawLine(pluma, 0, 80, 400, 80);
                    // e.Graphics.DrawLine(pluma, 0, 150, 400, 150);
                    e.Graphics.DrawLine(pluma, 0, 130, 400, 130);
                    // e.Graphics.DrawLine(pluma, 0, 200, 400, 200);
                    e.Graphics.DrawLine(pluma, 0, 180, 400, 180);
                    // e.Graphics.DrawLine(pluma, 0, 250, 400, 250);
                    // e.Graphics.DrawLine(pluma, 0, 230, 400, 230);
                    e.Graphics.DrawLine(pluma, 0, 230, 400, 230);


                    // e.Graphics.DrawLine(pluma, 0, 0, 400, 0);
                    // e.Graphics.DrawLine(pluma, 0, 300, 400, 300);
                    // e.Graphics.DrawLine(pluma, 0, 300, 0, 0);
                    // e.Graphics.DrawLine(pluma, 400, 300, 400, 0);

                    // Headers
                    ulong numeroSerie = Convert.ToUInt32(control.contadores.Where(x => (x.idContador == "GTX")).FirstOrDefault().contador);


     // Headers
        //la buena  e.Graphics.DrawString("PART NUMBER (P)", new Font("Arial", 15, FontStyle.Bold), new SolidBrush(Color.Black), 10, 10);
                    e.Graphics.DrawString("PART NUMBER (P)", new Font("Arial", 8, FontStyle.Bold), new SolidBrush(Color.Black), 10, 5);
                    // e.Graphics.DrawString("SERIAL (S)", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 310, 10);
                    // e.Graphics.DrawString("REVISION (2P)", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 10, 105);
                    e.Graphics.DrawString("REVISION (2P)", new Font("Arial", 8, FontStyle.Bold), new SolidBrush(Color.Black), 10, 85);

                    // e.Graphics.DrawString("QUANTITY (Q)", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 10, 155);
                    e.Graphics.DrawString("QUANTITY (Q)", new Font("Arial", 8, FontStyle.Bold), new SolidBrush(Color.Black), 10, 135);

                    // e.Graphics.DrawString("MANUFACTURE DATE (M)", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 10, 205);
     //la buena     // e.Graphics.DrawString("MANUFACTURE DATE (M)", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 10, 185);
                    e.Graphics.DrawString("MANUFACTURE DATE (M)", new Font("Arial", 8, FontStyle.Bold), new SolidBrush(Color.Black), 10, 185);

                    // e.Graphics.DrawString("SUPPLIER/VENDOR", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 10, 255);
      //la buena       e.Graphics.DrawString("SUPPLIER/VENDOR", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 10, 235);
                       e.Graphics.DrawString("SUPPLIER/VENDOR", new Font("Arial", 8, FontStyle.Bold), new SolidBrush(Color.Black), 10, 240);
                    // e.Graphics.DrawString("LOT NUMBER", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 260, 262);
      // la buena   // e.Graphics.DrawString("LOT NUMBER", new Font("Arial", 6, FontStyle.Bold), new SolidBrush(Color.Black), 260, 235);
                       e.Graphics.DrawString("LOT NUMBER", new Font("Arial", 8, FontStyle.Bold), new SolidBrush(Color.Black), 260, 240);

                    //CONTENIDO
          // la buena  e.Graphics.DrawString(serial, new Font("Arial", 15), new SolidBrush(Color.Black), 5, 20);
                       e.Graphics.DrawString(serial, new Font("Arial", 20, FontStyle.Bold), new SolidBrush(Color.Black), 5, 15);
                    // e.Graphics.DrawString(Base36.Base36Encode(numeroSereie, "XTG").ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), 280, 15);
                    // e.Graphics.DrawString(description, new Font("Arial", 10), new SolidBrush(Color.Black), 10, 85);
                    e.Graphics.DrawString(description, new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), 10, 68);

                    // e.Graphics.DrawString(revision, new Font("Arial", 15), new SolidBrush(Color.Black), 210, 110);
                    e.Graphics.DrawString(revision, new Font("Arial", 20, FontStyle.Bold), new SolidBrush(Color.Black), 225, 95);
                    // e.Graphics.DrawString(qty, new Font("Arial", 15), new SolidBrush(Color.Black), 210, 160);
                    e.Graphics.DrawString(qty, new Font("Arial", 20, FontStyle.Bold), new SolidBrush(Color.Black), 225, 145);
                    // e.Graphics.DrawString(manufactureDate, new Font("Arial", 20), new SolidBrush(Color.Black), 210, 210);
                    e.Graphics.DrawString(manufactureDate, new Font("Arial", 20, FontStyle.Bold), new SolidBrush(Color.Black), 215, 195);
                    // e.Graphics.DrawString("MEGA TECHWAY INC.", new Font("Arial", 15, FontStyle.Bold), new SolidBrush(Color.Black), 5, 265);
         // la buena   e.Graphics.DrawString("MEGA TECHWAY INC.", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), 5, 245);
                       e.Graphics.DrawString("MEGA TECHWAY INC.", new Font("Arial", 15, FontStyle.Bold), new SolidBrush(Color.Black), 5, 255);
                    // e.Graphics.DrawString(lote, new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), 260, 270);
         // la buena   e.Graphics.DrawString(lote, new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.Black), 260, 245);
                       e.Graphics.DrawString(lote, new Font("Arial", 15, FontStyle.Bold), new SolidBrush(Color.Black), 260, 255);

                    //CODIGOS DE BARRAS

                    // e.Graphics.DrawImage(Ejemplo.Write("P" + serial), 10, 50);
                    // e.Graphics.DrawImage(Ejemplo.Write("2P" + revision), 10, 117);
                    // e.Graphics.DrawImage(Ejemplo.Write("Q" + qty), 10, 167);
                    // e.Graphics.DrawImage(Ejemplo.Write("M" + manufactureDate), 10, 217);

                    //   e.Graphics.DrawImage(Ejemplo.Write("P" + serial), 10, 50);
        //la buena       e.Graphics.DrawImage(Ejemplo.Write("P" + serial),5, 35);
                    e.Graphics.DrawImage(Ejemplo.Write("P" + serial),10, 43);
                    // e.Graphics.DrawImage(Ejemplo.Write("2P" + revision), 10, 117);               
                    e.Graphics.DrawImage(Ejemplo.Write("2P" + revision), 5, 100);

                    e.Graphics.DrawImage(Ejemplo.Write("Q" + qty), 5, 150);
                    // e.Graphics.DrawImage(Ejemplo.Write("Q" + qty), recgtx3);
                    // e.Graphics.DrawImage(Ejemplo.Write("M" + manufactureDate), 10, 217);
         //el bueno //e.Graphics.DrawImage(Ejemplo.Write("M" + manufactureDate), 8, 195);
                    e.Graphics.DrawImage(Ejemplo.Write("M" + manufactureDate), 10, 200);

                    

              

        }

         
          void imprimirEtiqueta(ulong cantetiquetas){

     
            

            // var ip = "ZIT";
            // var ip = "Adobe PDF";
            var ip = "ZConL13";
            // var ip = "ZCelHalla";

            

            ulong totalEtiquetas = cantetiquetas;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintEtiquetaBolsa);
            pd.DefaultPageSettings.PrinterSettings.PrinterName = ip;

            // pd.DefaultPageSettings.PaperSize = new PaperSize("3x4", 400, 300);
            pd.DefaultPageSettings.PaperSize = new PaperSize("4x3", 400, 300);

            pd.DefaultPageSettings.Landscape = false; 
            // pd.DefaultPageSettings.Landscape = true;
            pd.Print();

        }
                var contadores = control.contadores.Where(x => (x.idContador == "GTX")).FirstOrDefault();
               ulong numeroSerie = Convert.ToUInt32(control.contadores.Where(x => (x.idContador == "GTX")).FirstOrDefault().contador);
            // try{
                foreach (var item in valor)
                {

                    item.ID_BOLSA = Base36.Base36Encode(numeroSerie, "XTG").ToString();
                    control.PROD_SERIALES_PRUEBAS.Add(item);
                    // var convertion = Convert.ToUInt32(control.contadores);
                    
                    // control.Entry(control.contadores.FirstOrDefault().contador =  
                    // Convert.ToUInt32(control.contadores.Where(x => (x.idContador == "GTX")).LastOrDefault().contador)+1).State = 
                    // Microsoft.EntityFrameworkCore.EntityState.Modified;
                    // contadores.contador += 1;l
                    // control.Entry(contadores).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    // control.SaveChanges();
                    
                   

                }
                
                imprimirEtiqueta(1);
                 contadores.contador += 1;
                 control.Entry(contadores).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                 control.SaveChanges();
                
               return Ok();
              
            // }
            // catch(Exception e){
            //     Console.WriteLine(e);
            //     return Ok();
            // }

        }

        

        // POST api/values
        [HttpPost]
        public  string Post([FromBody] PROD_SERIALES value)
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
 