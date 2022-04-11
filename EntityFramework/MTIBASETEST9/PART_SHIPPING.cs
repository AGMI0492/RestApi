using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MTIBASETEST9{

    public class PART_SHIPPING{

        public Nullable<Int32> ROWID { get; set; }
        public string CUSTOMER_ID { get; set; }
        public string SHIPTO_ID { get; set; }
        public string PART_ID { get; set; }
        public string CONTAINER_PART_ID { get; set; }
        // public string CONTAINER_UM { get; set; }
        // public Nullable<decimal> CONTAINER_WEIGHT { get; set; }
        public Nullable<decimal> STD_PCS_CONTAINER { get; set; }
        // public string SKID_PART_ID { get; set; }
        // public string SKID_UM { get; set; }
        // public Nullable<decimal> SKID_WEIGHT { get; set; }
        // public Nullable<decimal> STD_CONTAINER_SKID { get; set; }
        // public string CONTAINER_TYPE { get; set; }
        // public string DEFAULT_CONTAINER { get; set; }
        // public string CUST_SHIP_PART_ID { get; set; }
        public string PACKAGE_TYPE { get; set; }
        // public string CREATE_INV_TRANS { get; set; }
        // public string DOCK_CODE { get; set; }


    }

}