using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VISUAL7
{

    
    
    public class G_NPI_ENGINEERINGNPIP
    {
        public Nullable<Int32> ROWID { get; set;  }
        public string PART_ID { get; set; }
        public string REV_DRAWING_NO { get; set; }
        public Nullable<Int32> ITEM { get; set; }
        public string OPTIONS { get; set; }
        public Nullable<DateTime> DUE_DATE { get; set; }
        public string COMMENTS { get; set; }
        public Nullable<DateTime> CREATE_DATE { get; set; }
        public string USER_CREATE { get; set; }
        public Nullable<Int32> LINE_NO { get; set; }
        public string NPIP_NO { get; set; }
        public string PROCESS { get; set; }
        public string RESPONSIBLE { get; set; }
        public string RESPONSIBLE_NAME { get; set; }
        public string SEGMENT { get; set; }
        public string LINKS { get; set; }
        public string STATUS { get; set; }
    }


}