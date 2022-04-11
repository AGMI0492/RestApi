using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APPDB
{
    [Serializable]
    public class MT_MEGATOOLING
    {
       public string MT { get; set; }
       public string PART_NUMBER { get; set; }
       public string SERIAL { get; set; }
       public string APPLICATOR_MANUFACTURER { get; set; }
       public string TERMINAL_PART_NUMBER { get; set; }
       public string TERMINAL_MANUFACTURER { get; set; }
       public string AWG { get; set; }
       public string STRIP_LENGTH {get; set; }
       public string STRIP_LENGTH_TOLERANCE { get; set; }
       public Nullable<decimal> CRIMP_HEIGTH_WIRE { get; set; }
       public Nullable<decimal> CRIMP_HEIGTH_WIRE_TOLERANCE { get; set; }
       public string CRIMP_INSULATION_RANGE { get; set; }
       public string CRIMP_INSULATION_RANGE_TOLERANCE { get; set; }
       public string USED_IN { get; set; }
       public string AVAILABLE_EMAINT { get; set; }
       public string XSECTION_DATE { get; set; }
       public string VALIDATION_DATE { get; set; }
       public string COMMENTS { get; set; }

    }
}