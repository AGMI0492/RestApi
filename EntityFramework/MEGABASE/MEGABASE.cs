using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VISUAL7
{

      public class MEGABASEContext : DbContext
    {

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           
           //optionsBuilder.UseSqlServer("Data Source=192.168.1.18;Database=MEGABASE;User ID=SYSADM;Password=SYSADM;");
           optionsBuilder.UseSqlServer("Data Source=MTWDB01;Database=MTIBASE;User ID=SYSADM;Password=M3g@T3ch!;");
           
       }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<G_NPI_ENGINEERINGNPIP>()
                .HasKey(c =>new {c.ROWID});
                modelBuilder.Entity<G_NPI_ENGINEERING_INFOTABLE>()
                .HasKey(c =>new {c.ROWID});
                modelBuilder.Entity<G_NPI_ENGINEERINGNPIP_RESPONSIBLES>()
                .HasKey(c =>new {c.ID});
                modelBuilder.Entity<G_VISTA_ENGINEERINGNPIP_DATOS>()
                .HasKey(c =>new {c.PART_ID, c.DRAWING_REV_NO});
                 modelBuilder.Entity<PART>()
                .HasKey(c =>new {c.ID});
                 modelBuilder.Entity<PART_REV>()
                .HasKey(c =>new {c.ID, c.DRAWING_REV_NO});
                modelBuilder.Entity<TeamMembers>()
                .HasKey(c =>new {c.ROWID});
                modelBuilder.Entity<G_NPI_NPIPS>()
                .HasKey(c =>new {c.ROWID});
                 modelBuilder.Entity<VISTA_REQUIREMENT>()                                                                                 
                .HasKey(c =>new {c.WORKORDER_TYPE, c.WORKORDER_BASE_ID,c.WORKORDER_LOT_ID,c.WORKORDER_SPLIT_ID,c.WORKORDER_SUB_ID,
                                 c.OPERATION_SEQ_NO,c.PART_ID, c.PIECE_NO, c.RESOURCE_ID});
                 modelBuilder.Entity<G_VISTA_NPI_DASHBOARDTIEMPOS>()
                .HasKey(c =>new {c.ROWID});
                modelBuilder.Entity<G_VISTA_NPI_DASHBOARDWO>()
                .HasKey(c =>new {c.ROWID});
                modelBuilder.Entity<USER_DEF_FIELDS>()
                .HasKey( c=> new {c.ROWID});
                modelBuilder.Entity<VistaEtiGenericaN>()
                .HasKey(c=> new {c.WO});

        }

       public virtual DbSet<G_NPI_ENGINEERINGNPIP> G_NPI_ENGINEERINGNPIP { get; set; }
       public virtual DbSet<G_NPI_ENGINEERING_INFOTABLE> G_NPI_ENGINEERING_INFOTABLE { get; set; }
       public virtual DbSet<G_NPI_ENGINEERINGNPIP_RESPONSIBLES> G_NPI_ENGINEERINGNPIP_RESPONSIBLES { get; set; }
       public virtual DbSet<G_VISTA_ENGINEERINGNPIP_DATOS> G_VISTA_ENGINEERINGNPIP_DATOS { get; set; }
       public virtual DbSet<PART> PART { get; set; }
       public virtual DbSet<PART_REV> G_VISTA_ENGINEERINGNPIP_BASEID_DRAWINGREVNO { get; set; }
       public virtual DbSet<TeamMembers> G_NPI_TEAMWORKMEMBERS { get; set; }
       public virtual DbSet<G_NPI_NPIPS> G_NPI_NPIPS { get; set; }
       public virtual DbSet<VISTA_REQUIREMENT> VISTA_REQUIREMENT { get; set; }
       public virtual DbSet<G_VISTA_NPI_DASHBOARDTIEMPOS> G_VISTA_NPI_DASHBOARDTIEMPOS { get; set; }
       public virtual DbSet<G_VISTA_NPI_DASHBOARDWO> G_VISTA_NPI_DASHBOARDWO { get; set; }
       public virtual DbSet<USER_DEF_FIELDS> USER_DEF_FIELDS { get; set; }
       public virtual DbSet<VistaEtiGenericaN> VistaEtiGenericaN { get; set; }
       
    }
   

       

    


}