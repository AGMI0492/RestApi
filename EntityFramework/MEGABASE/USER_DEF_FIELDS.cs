using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VISUAL7
{

  
       
    
    public class USER_DEF_FIELDS
    {
        public string PROGRAM_ID { get; set;  }
        public string ID { get; set; }
        public string DOCUMENT_ID { get; set; }
        public Nullable<Int32> LINE_NO { get; set; }
        public Nullable<Int32> DEL_LINE_NO { get; set; }
        public string LABEL { get; set; }
        public Nullable<Int32> DATA_TYPE { get; set; }
        public string DISPLAY_FORMAT { get; set; }
        public Nullable<Int32> TAB_OR_TABLE { get; set; }
        public string TAB_ID { get; set; }
        public string TABLE_ID { get; set; }
        public Nullable<Int32> SEQUENCE_NO { get; set; }
        public Nullable<Int32> UDF_REQUIRED { get; set; }
        public string STRING_VAL { get; set; }
        public Nullable<decimal> NUMBER_VAL { get; set; }
        public Nullable<Int32> BOOL_VAL { get; set; }
        public Nullable<DateTime> DATE_VAL { get; set; }
        public Nullable<Int32> ROWID { get; set; }
    }


}