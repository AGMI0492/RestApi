using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace APPDB
{
    public class AJUSTADORES_GRAPADO
    {
        public int ROWID { get; set; }
        public string TIPO_AJUSTE { get; set; }
        public string EMPLEADO { get; set; }
        public string AREA { get; set; }
        public string ESTACION { get; set; }
        public string NUMERO_MT { get; set; }
        public string AJUSTADOR { get; set; }
        public Nullable<DateTime> HORA_INICIO { get; set; }
        public Nullable<DateTime> HORA_TERMINACION { get; set; }
        public Nullable<DateTime> INICIO {get; set; }
        public string COMENTARIOS { get; set; }


    }

}