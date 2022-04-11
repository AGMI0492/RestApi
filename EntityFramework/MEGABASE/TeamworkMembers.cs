using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VISUAL7{

    public class TeamMembers{

        public Nullable<Int32> ROWID { get; set; }
        public string EMP_NUMBER { get; set; }
        public string LAST_NAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string TEAM_NAME { get; set; }
        public string EMAIL_ADDR { get; set; }

    }

}