using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VISUAL7
{

   

       
    
    public class VISTA_REQUIREMENT
    {
        public Nullable<Int32> ROWID { get; set;  }
        public string WORKORDER_TYPE { get; set; }
        public string WORKORDER_BASE_ID { get; set; }
        public string WORKORDER_LOT_ID { get; set; }
        public string WORKORDER_SPLIT_ID { get; set; }
        public string WORKORDER_SUB_ID { get; set; }
        public Nullable<Int16> OPERATION_SEQ_NO { get; set; }
        public Nullable<Int16> PIECE_NO { get; set; }
        public string SUBORD_WO_SUB_ID { get; set; }
        public string PART_ID { get; set; }
        public string REFERENCE { get; set; }
        public string STATUS { get; set; }
        public Nullable<decimal> QTY_PER { get; set; }
        public string QTY_PER_TYPE { get; set; }
        public Nullable<decimal> FIXED_QTY { get; set; }
        public Nullable<decimal> SCRAP_PERCENT { get; set; }
        public string DIMENSIONS { get; set; }
        public string DIM_EXPRESSION { get; set; }
        public string USAGE_UM { get; set; }
        public Nullable<DateTime> EFFECTIVE_DATE { get; set; }
        public Nullable<DateTime> DISCONTINUE_DATE {get; set; }
        public Nullable<decimal> CALC_QTY {get; set; }
        public Nullable<decimal> ISSUED_QTY { get; set; }
        public Nullable<DateTime> REQUIRED_DATE { get; set; }
        public Nullable<DateTime> CLOSE_DATE { get; set; }
        public Nullable<decimal> UNIT_MATERIAL_COST { get; set; }
        public Nullable<decimal> UNIT_LABOR_COST { get; set; }
        public Nullable<decimal> UNIT_SERVICE_COST { get; set; }
        public Nullable<decimal> BURDEN_PERCENT { get; set; }
        public Nullable<decimal> BURDEN_PER_UNIT { get; set; }
        public Nullable<decimal> FIXED_COST { get; set; }
        public string DRAWING_ID { get; set; }
        public string DRAWING_REV_NO { get; set; }
        public string VENDOR_ID { get; set; }
        public string VENDOR_PART_ID { get; set; }
        public Nullable<decimal> EST_MATERIAL_COST { get; set; }
        public Nullable<decimal> EST_LABOR_COST { get; set; }
        public Nullable<decimal> EST_BURDEN_COST { get; set; }
        public Nullable<decimal> EST_SERVICE_COST { get; set; }
        public Nullable<decimal> REM_MATERIAL_COST { get; set; }
        public Nullable<decimal> REM_LABOR_COST { get; set; }
        public Nullable<decimal> REM_BURDEN_COST { get; set; }
        public Nullable<decimal> REM_SERVICE_COST { get; set; }
        public Nullable<decimal> ACT_MATERIAL_COST { get; set; }
        public string QTYPRINT { get; set; }
        public string DESCRIPTION { get; set; }
        public string RESOURCE_ID { get; set; }
        public string WORKORDER_STATUS { get; set; }
        public string WORKORDER_PART_ID { get; set; }
   
      

    }


}