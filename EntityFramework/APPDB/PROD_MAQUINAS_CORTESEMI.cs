using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace APPDB
{
    public class PROD_MAQUINAS_CORTESEMIAUTO
    {
        public Nullable<Int32> ROWID { get; set; }
        public string EMPLEADO {get; set; }
        public string WO { get; set; }
        public string CLIENTE { get; set; }
        public string REVISION { get; set; }
        public string CIRCUITO { get; set; }
        public string NUMERO_PARTE_CABLE { get; set; }
        public string NUMERO_PARTE_CABLE_FISICO { get; set; }
        public string LONGITUD { get; set; }
        public string DEPILADO_LADO_A { get; set; }
        public string DEPILADO_LADO_B { get; set; }
        public string DESFORRE_LADO_A { get; set; }
        public string DESFORRE_LADO_B { get; set; }
        public string ESTAMPADO_LADO_A { get; set; }
        public string ESTAMPADO_LADO_B { get; set; }
        public string DATOS_EN_ESPECIFICACION { get; set; }
        public Nullable<Int32> CANTIDAD_REQUERIDA { get; set; }
        public Nullable<Int32> CANTIDAD_CORTADA { get; set; }
        // public string COMENTARIOS { get; set; }
        public Nullable<DateTime> FECHA { get; set; }
        public string NUMERO_MAQUINA { get; set; }
        public string COMENTARIOS { get; set; }



        
    }

}