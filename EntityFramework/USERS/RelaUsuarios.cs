using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VISTA_RELACION_USUARIOS_OHR
{

      public class UsersContext : DbContext
    {

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           
           optionsBuilder.UseSqlServer("Data Source=10.100.0.5;Database=Users;User ID=SYSADM;Password=M3g@T3ch!;");
           
       }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VISTA_RELACION_USUARIOS_OHR>()
                .HasKey(c =>new {c.USER_ID});
        }

       public virtual DbSet<VISTA_RELACION_USUARIOS_OHR> VISTA_RELACION_USUARIOS_OHR { get; set; }
    
    }

       
    
//     public class VISTA_RELACION_USUARIOS_OHR
//     {
//         public Nullable<Int32> EMPLEADO { get; set;  }
//         public string NOMBRE { get; set; }
//         public string PATERNO { get; set; }
//         public string MATERNO { get; set; }
//         public string DEP_DESCR { get; set; }
//         public string USER_ID { get; set; }
//         public string PASSWORD { get; set; }
//         public string VIGENCIA { get; set; }
//         public string RolName { get; set; }
//         public string Id { get; set; }
//         public string RolId { get; set; }
//     }


// }
}