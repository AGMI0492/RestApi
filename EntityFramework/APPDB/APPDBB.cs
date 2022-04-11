using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace APPDB
{

      public class APPDBContext : DbContext
    {

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           
           //optionsBuilder.UseSqlServer("Data Source=192.168.1.18;Database=AppDBB;User ID=SYSADM;Password=SYSADM;");
           optionsBuilder.UseSqlServer("Data Source=MTWDB01;Database=APPDB;User ID=SYSADM;Password=M3g@T3ch!;");
       }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<G_NPI_CAMBIOS_STATUS>()
                .HasKey(c =>new {c.ROWID}); 
                modelBuilder.Entity<G_NPIP_RASTREO>()
                .HasKey(c =>new {c.ROWID});
                modelBuilder.Entity<AG_PULLTEST>()
                .HasKey(c =>new {c.TIPO, c.CALIBRE});
                modelBuilder.Entity<Grapado_Terminal>()
                .HasKey(c => new {c.ROWID});
                modelBuilder.Entity<AJUSTADORES_GRAPADO>()
                .HasKey(c => new {c.ROWID});
                 modelBuilder.Entity<Grapado_Ferrul>()
                .HasKey(c => new {c.ROWID});
                 modelBuilder.Entity<Grapado_Ferrul_Terminal>()
                .HasKey(c => new {c.ROWID});
                modelBuilder.Entity<PROD_SERIALES>()
                .HasKey(c=> new {c.SERIAL});
                modelBuilder.Entity<MT_MEGATOOLING>()
                .HasKey(c=> new {c.MT, c.PART_NUMBER, c.AWG});
                modelBuilder.Entity<PROD_SERIALES_DYNALAB>()
                .HasKey(c=> new {c.ROWID});
                modelBuilder.Entity<DYNALAB>()
                .HasKey(c=>new {c.IP});
                modelBuilder.Entity<PROD_PC_PRINTER>()
                .HasKey(c=>new {c.IP_ADDRESS});
                modelBuilder.Entity<PROD_SERIALES_PRUEBAS>()
                .HasKey(c=>new {c.SERIAL});
                modelBuilder.Entity<contadores>()
                .HasKey(c=>new {c.idContador});
                modelBuilder.Entity<PROD_SERIALES_BOLSAS_PROD>()
                .HasKey(c=>new {c.ROWID});
                modelBuilder.Entity<PROD_MAQUINAS_CORTESEMIAUTO>()
                .HasKey(c=>new {c.ROWID});
                modelBuilder.Entity<VISTA_PROD_SERIALES_RELACIONADOS>()
                .HasKey(c=> new {c.SERIAL});
               
        }

       public virtual DbSet<G_NPI_CAMBIOS_STATUS> G_NPI_CAMBIOS_STATUS { get; set; }
       public virtual DbSet<G_NPIP_RASTREO> G_NPIP_RASTREO { get; set; }
       public virtual DbSet<AG_PULLTEST> AG_PULLTEST { get; set; }
       public virtual DbSet<Grapado_Terminal> Grapado_Terminal { get; set; }
       public virtual DbSet<AJUSTADORES_GRAPADO> AJUSTADORES_GRAPADO { get; set; }
       public virtual DbSet<Grapado_Ferrul> Grapado_Ferrul { get; set; }
       public virtual DbSet<Grapado_Ferrul_Terminal> Grapado_Ferrul_Terminal { get; set; }
       public virtual DbSet<PROD_SERIALES> PROD_SERIALES { get; set; }
       public virtual DbSet<MT_MEGATOOLING> MT_MEGATOOLING {get; set; }
       public virtual DbSet<PROD_SERIALES_DYNALAB> PROD_SERIALES_DYNALAB { get; set; }
       public virtual DbSet<DYNALAB> DYNALABs { get; set; }
       public virtual DbSet<PROD_PC_PRINTER> PROD_PC_PRINTER {get; set; }
       public virtual DbSet<PROD_SERIALES_PRUEBAS> PROD_SERIALES_PRUEBAS { get; set; }
       public virtual DbSet<contadores> contadores { get; set; }
       public virtual DbSet<PROD_SERIALES_BOLSAS_PROD> PROD_SERIALES_BOLSAS_PROD { get; set; }
       public virtual DbSet<PROD_MAQUINAS_CORTESEMIAUTO> PROD_MAQUINAS_CORTESEMIAUTO { get; set; }
       public virtual DbSet<VISTA_PROD_SERIALES_RELACIONADOS> VISTA_PROD_SERIALES_RELACIONADO { get; set; }


    }
   

       

    


}