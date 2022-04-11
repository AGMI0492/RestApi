using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace APPDB
{
    public class PROD_SERIALES
    {
        // public Nullable<Int32> ROWID { get; set; }
        public Nullable<DateTime> FECHA {get; set; }
        public string SERIAL { get; set; }
        // public string WO { get; set; }
        // public string DESCRIPCION { get; set; }
        // public string REVISION { get; set; }
        // public string QTY { get; set; }

      
        
    }

}