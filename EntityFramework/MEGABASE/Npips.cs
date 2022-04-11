using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VISUAL7{

    public class G_NPI_NPIPS{

        public int ROWID { get; set; }
        public string NPIP_NO { get; set; }
        public Nullable<DateTime> CREATE_DATE { get; set; }
        public string CREATE_USER { get; set; }
        public string PART_ID { get; set; }
        public string REV_DRAWING_NO { get; set; }

    }

}