using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace VISUAL7{

public class G_VISTA_NPI_DASHBOARDWO{

public Nullable<Int32> ROWID { get; set; }
public string WORKORDER_BASE_ID { get; set; }
public Nullable<DateTime> DESIRED_RLS_DATE { get; set; }
public Nullable<DateTime> CREATE_DATE { get; set; }
public string EMPLOYEE_ID { get; set; }
public string RESOURCE_ID { get; set; }
public Nullable<DateTime> CLOCK_IN { get; set; }
public Nullable<DateTime> CLOCK_OUT { get; set; }
public Nullable<decimal> HOURS_WORKED { get; set; }
public Nullable<double> HRPWO { get; set; }
public Nullable<double> DELTASTD { get; set; }
public Nullable<decimal> HOURSWORKEDTOTAL { get; set; }
public Nullable<Int32> PENDING_TO_SHIP { get; set; }
public Nullable<Int32> WO_PEND {get; set; }
public Nullable<DateTime> aprobacion { get; set; }
public string so { get; set; }
public string line { get; set; }


}



}