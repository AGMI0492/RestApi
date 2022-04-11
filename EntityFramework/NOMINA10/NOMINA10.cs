using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace NOMINA10
{

      public class NOMINA10Context : DbContext
    {

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           
           //optionsBuilder.UseSqlServer("Data Source=192.168.1.18;Database=AppDBB;User ID=SYSADM;Password=SYSADM;");
           optionsBuilder.UseSqlServer("Data Source=RYVS002;Database=NOMINA10;User ID=SA;Password=m1fLc4gR1i;");
       }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VW_PYEM_EMPLEADOSACTIVOS>()
                .HasKey(c =>new {c.EMPLEADO}); 
              
              
               
        }

   
    public virtual DbSet<VW_PYEM_EMPLEADOSACTIVOS> VW_PYEM_EMPLEADOSACTIVOS { get; set; }
     


    }
   

       

    


}