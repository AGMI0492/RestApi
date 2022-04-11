using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace APPDB
{
    public class PROD_PC_PRINTER
    {
        public string IP_ADDRESS { get; set; }
        public string PRINTER_NAME { get; set; }
        
    }

}