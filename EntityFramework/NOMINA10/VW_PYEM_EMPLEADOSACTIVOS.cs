using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NOMINA10
{

  
       
    
    public class VW_PYEM_EMPLEADOSACTIVOS
    {
        public string EMPLEADO { get; set;  }
        public string NOMBRE { get; set; }
        public string DEP_DESCR { get; set; }
        public string JEFE_NUM { get; set; }
        public string JEFE_NOM { get; set; }
        public string IMSS { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        public Nullable<DateTime> FNACIMIENTO { get; set; }
        public string DEPTO_ID { get; set; }
        public string VIGENCIA { get; set; }
        public string ESTUDIO_ID { get; set; }
        public string ESTUD_DESCR { get; set; }
        public string EDONAC { get; set; }
        public string nombreEstado { get; set; }
        public string CIUDADNAC { get; set; }
        public string nombreMunicipio { get; set; }
        public string CALLE { get; set; }
        public string NUMERO { get; set; }
        public string EDO { get; set; }
        public string Expr2 { get; set; } 
        public string CIUDAD { get; set; }
        public string LOCALIDAD { get; set; }
        public string Expr3 { get; set; }
        public string COLONIA { get; set; }
        public string CP { get; set; }
        public string SINDCONF { get; set; }
        public string C_S { get; set; }
        public string DIRECTO { get; set; }
        public string DI { get; set; }
        public string OCUPA_ID { get; set; }
        public string OCUPACION { get; set; }
        public string VENCE { get; set; }
        public string VENCECONT { get; set; }
        public string TELEFONO { get; set; }
        public string EMPBANORTE { get; set; }
        public string CBANORTE { get; set; }
        public string ECIVIL_BANORTE { get; set; }
        public string DESCRIPCION { get; set; }
        public string SEXO { get; set; }
        public string SEXOO { get; set; }
        public Nullable<DateTime> ALTA { get; set; }
        public string TURNO { get; set; }
        public string EDO_NACIMIENTO { get; set; }
        public string MOVIL_PERSONAL { get; set; }
        public string JEFE_INMEDIATO { get; set; }
        public string Expr1 { get; set; }
        public string CTA_SODEXO { get; set; }
        public string HIJOS { get; set; }
        public string EMAIL { get; set; }
        public string CORREO_PERSONAL { get; set; }
        public string TITULO { get; set; }
        public string DEPTO_ID_JEFE { get; set; }
        public string DEP_DESCR_JEFE { get; set; }





        
    }


}