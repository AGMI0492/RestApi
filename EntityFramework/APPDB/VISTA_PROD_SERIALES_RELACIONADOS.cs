using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace APPDB
{
    public class VISTA_PROD_SERIALES_RELACIONADOS
    {
        public Nullable<DateTime> PRINTED_DATE {get; set; }
        public string SERIAL { get; set; }
        public string WORKORDER { get; set; }
        public string PART_ID { get; set; }
        public string PROGRAM_TYPE { get; set; }
        public string FOLIO { get; set; }
        // public string DESCRIPCION { get; set; }

        
    }

}