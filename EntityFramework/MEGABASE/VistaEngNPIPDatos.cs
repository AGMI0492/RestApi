using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VISUAL7
{

   

       
    
    public class G_VISTA_ENGINEERINGNPIP_DATOS
    {
        public string ID { get; set;  }
        public string STRING_VAL { get; set; }
        public string DRAWING_REV_NO { get; set; }
        public string PART_ID { get; set; }
        public Nullable<DateTime> ORDER_DATE { get; set; }
        public Nullable<DateTime> DOCK_DATE { get; set; }
        public string CUST_ORDER_ID { get; set; }
        public Nullable<Int16> LINE_NO { get; set; }
        public Nullable<DateTime> CREATE_DATE { get; set; }
        public Nullable<decimal> ORDER_QTY { get; set; }
        public string USER_4 { get; set; }
    }


}