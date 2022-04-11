using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace APPDB
{
    public class Grapado_Terminal
    {
        public Nullable<Int32> ROWID { get; set; }
        public Nullable<Int32> TURNO { get; set; }
        public DateTime FECHA { get; set; }
        public string MAQUINA { get; set; }
        public string NUMERO_MT { get; set; }
        public string CLIENTE { get; set; }
        public string EMPLEADO { get; set; }
        public string WO { get; set; }
        public string PART_ID { get; set; }
        public string DRAWING_REV_NO { get; set; }
        public string COMPONENT { get; set; }
        public string NUMERO_CIRCUITO { get; set; }
        public string LADO { get; set; }
        public string ALTURA_BARRIL { get; set; }
        public string ALTURA_CINCHO { get; set; }
        public string VALOR_FUERZA { get; set; }
        public string RESULTADO { get; set; }
        public string EQUIPO_PULLTEST { get; set; }
        public Nullable<Int32> CANTIDAD_REQUERIDA { get; set; }
        public Nullable<Int32> CANTIDAD_CORTADA { get; set; }
        public string COMENTARIOS { get; set; } 
        public string APLICADOR { get; set; }

        public string RECURSO { get; set; }

    }

}