using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VISUAL7
{

  
       
    
    public class G_NPI_ENGINEERINGNPIP_RESPONSIBLES
    {
        public Nullable<Int32> ID { get; set;  }
        public string NPIP_NO { get; set; }
        public string RESPONSIBLE_NAME { get; set; }
        public string RESPONSIBLE_TEAM { get; set; }
    }


}