using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace APPDB
{
    public class PROD_SERIALES_DYNALAB
    {
        public Nullable<Int32> ROWID { get; set; }
        public Nullable<DateTime> PRINTED_DATE {get; set; }
        public string SERIAL { get; set; }
        public string WO { get; set; }
        public string IP_ADDRESS { get; set; }
        public string PROGRAM_TYPE { get; set; }
        public string FOLIO { get; set; }
        // public string DESCRIPCION { get; set; }

        
    }

}