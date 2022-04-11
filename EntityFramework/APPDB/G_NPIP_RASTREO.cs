using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APPDB
{

  
       
    
    public class G_NPIP_RASTREO
    {
        public int ROWID { get; set;  }
        public string SO { get; set; }
        public int LINEA { get; set; }
        public string STATUS { get; set; }
        public string EHO_ANALYST { get; set; }
    }


}