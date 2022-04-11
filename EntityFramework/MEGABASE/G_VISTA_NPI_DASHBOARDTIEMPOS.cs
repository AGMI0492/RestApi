using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace VISUAL7{


    public class G_VISTA_NPI_DASHBOARDTIEMPOS{

        [Key]
        public Nullable<Int32> ROWID { get; set; }
        public string PART_ID { get; set; }
        public string DRAWING_REV_NO { get; set; }
        public string WO { get; set; }
        public Nullable<DateTime> START_DATE { get; set; }
        public Nullable<DateTime> SHIP_DATE { get; set; }
        public Nullable<DateTime> DUE_DATE { get; set; }
        public double MINLABOR { get; set; }
        public double  CAUTOMATICO { get; set; }
        public double CMANUAL { get; set; }
        
        public double SEMIAUTOGROUP { get; set; }
        [Column(name: "S-ESTAMPAGROUP")]
        public double SESTAMPAGROUP { get; set; }

        [Column(name: "S-ESTAMPA1822")]
        public double SESTAMPA1822 { get; set; }
        public double CTUBO { get; set; }
        public double CPREPARACION { get; set; }
        public double ULTRASONICWELD { get; set;  }
        public double SOLDADURA { get; set; }
        public double AREADEGRAPADO { get; set; }
        public double CELDAS { get; set; }
        public double CONVEYOR { get; set; }
        public double TIEMPO { get; set; }
        public double SETUPTIEMPO { get; set; }
        public string SO { get; set; }
        public string SO2 { get; set; }
        public string LINE { get; set; }
        public double TT50 { get; set; }
        public double RATEPCS { get; set; }
        public double HRPWO { get; set; }
        public double HRPWOSU { get; set; }
        public double SHIFTS { get; set; }
    }

}