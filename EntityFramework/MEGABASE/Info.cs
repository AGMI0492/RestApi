using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VISUAL7
{

   

       
    
    public class G_NPI_ENGINEERING_INFOTABLE
    {
       public Nullable<Int32> ROWID { get; set; }
       public string Process { get; set; }
       public string Responsable { get; set; }
       public int Item { get; set; }
       public int Line { get; set; }
    }


}