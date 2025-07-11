using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Graduation_Project.Models;

public partial class Final_ProjectContext : DbContext
{
    public Final_ProjectContext(DbContextOptions<Final_ProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ALEX_BUILDING> ALEX_BUILDINGs { get; set; }

    public virtual DbSet<FINAL_TRANSECT> FINAL_TRANSECTs { get; set; }

    public virtual DbSet<SHORELINES_1986_2023> SHORELINES_1986_2023s { get; set; }

    public virtual DbSet<SHORELINES_1986_2100> SHORELINES_1986_2100s { get; set; }

    public virtual DbSet<SHORELINE_1986_2023_FINAL> SHORELINE_1986_2023_FINALs { get; set; }

    public virtual DbSet<SHORELINE_1986_2023__PROJECT> SHORELINE_1986_2023__PROJECTs { get; set; }

    public virtual DbSet<SHORELINE_1986_2023__PROJECT_FINAL> SHORELINE_1986_2023__PROJECT_FINALs { get; set; }

    public virtual DbSet<SHORELINE_1986_POINTS_100M> SHORELINE_1986_POINTS_100Ms { get; set; }

    public virtual DbSet<SHORELINE_1986_PROJECT> SHORELINE_1986_PROJECTs { get; set; }

    public virtual DbSet<SHORELINE_1986_SEGMENTED_100M> SHORELINE_1986_SEGMENTED_100Ms { get; set; }

    public virtual DbSet<SHORELINE_1986_SEGMENTED_PROJECT> SHORELINE_1986_SEGMENTED_PROJECTs { get; set; }

    public virtual DbSet<SHORELINE_1986_SPLIT_PROJECT> SHORELINE_1986_SPLIT_PROJECTs { get; set; }

    public virtual DbSet<SHORELINE_2007_POINTS_100M> SHORELINE_2007_POINTS_100Ms { get; set; }

    public virtual DbSet<SHORELINE_2007_SEGMENTED_100M> SHORELINE_2007_SEGMENTED_100Ms { get; set; }

    public virtual DbSet<SHORELINE_2007_SEGMENTED_PROJECT> SHORELINE_2007_SEGMENTED_PROJECTs { get; set; }

    public virtual DbSet<SHORELINE_2013_POINTS_100M> SHORELINE_2013_POINTS_100Ms { get; set; }

    public virtual DbSet<SHORELINE_2013_SEGMENTED_100M> SHORELINE_2013_SEGMENTED_100Ms { get; set; }

    public virtual DbSet<SHORELINE_2013_SEGMENTED_PROJECT> SHORELINE_2013_SEGMENTED_PROJECTs { get; set; }

    public virtual DbSet<SHORELINE_2018_POINTS_100M> SHORELINE_2018_POINTS_100Ms { get; set; }

    public virtual DbSet<SHORELINE_2018_SEGMENTED_100M> SHORELINE_2018_SEGMENTED_100Ms { get; set; }

    public virtual DbSet<SHORELINE_2018_SEGMENTED_PROJECT> SHORELINE_2018_SEGMENTED_PROJECTs { get; set; }

    public virtual DbSet<SHORELINE_2023_AFTER> SHORELINE_2023_AFTERs { get; set; }

    public virtual DbSet<SHORELINE_2023_CVI_1KM> SHORELINE_2023_CVI_1KMs { get; set; }

    public virtual DbSet<SHORELINE_2023_POINTS_100M> SHORELINE_2023_POINTS_100Ms { get; set; }

    public virtual DbSet<SHORELINE_2023_POINTS_250M> SHORELINE_2023_POINTS_250Ms { get; set; }

    public virtual DbSet<SHORELINE_2023_SEGMENTED_100M> SHORELINE_2023_SEGMENTED_100Ms { get; set; }

    public virtual DbSet<SHORELINE_2023_SEGMENTED_PROJECT> SHORELINE_2023_SEGMENTED_PROJECTs { get; set; }

    public virtual DbSet<SHORELINE_2023_SEGMEN_BUFFER> SHORELINE_2023_SEGMEN_BUFFERs { get; set; }

    public virtual DbSet<SHORELINE_BASELINE> SHORELINE_BASELINEs { get; set; }

    public virtual DbSet<SHORELINE_RATES_SEGMENTED_CLOSEST> SHORELINE_RATES_SEGMENTED_CLOSESTs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ALEX_BUILDING>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__ALEX_BUI__F4B70D853C67896B");

            entity.ToTable("ALEX_BUILDINGS");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.ADDR_CITY).HasMaxLength(80);
            entity.Property(e => e.ADDR_NUM).HasMaxLength(80);
            entity.Property(e => e.ADDR_ST).HasMaxLength(91);
            entity.Property(e => e.BLDG_TYPE).HasMaxLength(80);
            entity.Property(e => e.BLDG_USE).HasMaxLength(80);
            entity.Property(e => e.CENT_X).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.CENT_Y).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Class_Name).HasMaxLength(255);
            entity.Property(e => e.DIST_COAST).HasMaxLength(80);
            entity.Property(e => e.ELEVATION).HasMaxLength(80);
            entity.Property(e => e.EST_OCCUP).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.EST_VALUE).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.HEIGHT).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.LEVELS).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.NAME).HasMaxLength(92);
            entity.Property(e => e.PERIM_M).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.STATUS).HasMaxLength(80);
            entity.Property(e => e.Shape).HasColumnType("geometry");
            entity.Property(e => e.VAL_USD_M2).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.VULN_SCORE).HasColumnType("numeric(38, 8)");
        });

        modelBuilder.Entity<FINAL_TRANSECT>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__FINAL_TR__F4B70D853D57B981");

            entity.ToTable("FINAL_TRANSECT");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.BaselineID).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.DistanceToBase2007).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Dt_To_Shoreline_2007).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Dt_To_Shoreline_2013).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Dt_To_Shoreline_2018).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Dt_To_Shoreline_2023).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.EPR).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.EPRunc).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.LCI).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.LR2).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.LRR).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.LSE).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.NSM).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.ObjectID_1).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.SCE).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Shape).HasColumnType("geometry");
            entity.Property(e => e.Shape_Length_1).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.ShrCount).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.TCD).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.TransEdit).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.TransOrder).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.TransectId).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.WCI).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.WLR).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.WR2).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.WSE).HasColumnType("numeric(38, 8)");
        });

        modelBuilder.Entity<SHORELINES_1986_2023>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D859081DF41");

            entity.ToTable("SHORELINES_1986_2023");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.MERGE_SRC).HasMaxLength(255);
            entity.Property(e => e.SHAPE_LENGTH1).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINES_1986_2100>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D85C6BFC7F7");

            entity.ToTable("SHORELINES_1986_2100");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_1986_2023_FINAL>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D85D160002E");

            entity.ToTable("SHORELINE_1986_2023_FINAL");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.MERGE_SRC).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_1986_2023__PROJECT>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D85DB77DB9D");

            entity.ToTable("SHORELINE_1986_2023__PROJECT");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.MERGE_SRC).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_1986_2023__PROJECT_FINAL>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D8531C358D1");

            entity.ToTable("SHORELINE_1986_2023__PROJECT_FINAL");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.MERGE_SRC).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_1986_POINTS_100M>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D85D7FEEE2C");

            entity.ToTable("SHORELINE_1986_POINTS_100M");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.Base).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.FolderPath).HasMaxLength(320);
            entity.Property(e => e.Name).HasMaxLength(320);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_1986_PROJECT>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D85CE9C7F9E");

            entity.ToTable("SHORELINE_1986_PROJECT");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.Base).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.FolderPath).HasMaxLength(320);
            entity.Property(e => e.Length).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Name).HasMaxLength(320);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_1986_SEGMENTED_100M>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D8530A4DCD7");

            entity.ToTable("SHORELINE_1986_SEGMENTED_100M");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_1986_SEGMENTED_PROJECT>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D85328A8C48");

            entity.ToTable("SHORELINE_1986_SEGMENTED_PROJECT");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.Dt_To_Shoreline_2007).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Dt_To_Shoreline_2013).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Dt_To_Shoreline_2018).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Dt_To_Shoreline_2023).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_1986_SPLIT_PROJECT>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D858352B2DB");

            entity.ToTable("SHORELINE_1986_SPLIT_PROJECT");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.Shape).HasColumnType("geometry");
            entity.Property(e => e.ShapeLength).HasColumnType("numeric(38, 8)");
        });

        modelBuilder.Entity<SHORELINE_2007_POINTS_100M>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D85684E4D98");

            entity.ToTable("SHORELINE_2007_POINTS_100M");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.Base).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.FolderPath).HasMaxLength(320);
            entity.Property(e => e.Name).HasMaxLength(320);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2007_SEGMENTED_100M>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D85CBC8AC40");

            entity.ToTable("SHORELINE_2007_SEGMENTED_100M");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2007_SEGMENTED_PROJECT>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D85CB551998");

            entity.ToTable("SHORELINE_2007_SEGMENTED_PROJECT");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2013_POINTS_100M>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D8545C02FB6");

            entity.ToTable("SHORELINE_2013_POINTS_100M");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.Base).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.FolderPath).HasMaxLength(320);
            entity.Property(e => e.Name).HasMaxLength(320);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2013_SEGMENTED_100M>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D85346E68DE");

            entity.ToTable("SHORELINE_2013_SEGMENTED_100M");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2013_SEGMENTED_PROJECT>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D8597EEA984");

            entity.ToTable("SHORELINE_2013_SEGMENTED_PROJECT");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2018_POINTS_100M>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D85252320A2");

            entity.ToTable("SHORELINE_2018_POINTS_100M");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.Base).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.FolderPath).HasMaxLength(320);
            entity.Property(e => e.Name).HasMaxLength(320);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2018_SEGMENTED_100M>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D85BFA21B4C");

            entity.ToTable("SHORELINE_2018_SEGMENTED_100M");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2018_SEGMENTED_PROJECT>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D859A3AE764");

            entity.ToTable("SHORELINE_2018_SEGMENTED_PROJECT");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2023_AFTER>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D85124ABA1F");

            entity.ToTable("SHORELINE_2023_AFTER");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.CVI_Classify).HasMaxLength(255);
            entity.Property(e => e.EPR_Category).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2023_CVI_1KM>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D8567384297");

            entity.ToTable("SHORELINE_2023_CVI_1KM");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.CVI_Classify).HasMaxLength(255);
            entity.Property(e => e.EPR_Category).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2023_POINTS_100M>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D853646A2E0");

            entity.ToTable("SHORELINE_2023_POINTS_100M");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.Coastal_Slope).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Current_Position_X).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Current_Position_Y).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Elevation).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.LRR).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.NSM).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Position_2030_X).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Position_2030_Y).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Position_2035_X).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Position_2035_Y).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Position_2040_X).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Position_2040_Y).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Position_2045_X).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Position_2045_Y).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Position_2050_X).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Position_2050_Y).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Position_2100_X).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Position_2100_Y).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Sea_Level_Rise_Trend_mm_year).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2023_POINTS_250M>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D854F651E4F");

            entity.ToTable("SHORELINE_2023_POINTS_250M");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.Base).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.FolderPath).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2023_SEGMENTED_100M>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D8552250551");

            entity.ToTable("SHORELINE_2023_SEGMENTED_100M");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2023_SEGMENTED_PROJECT>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D856C64F29E");

            entity.ToTable("SHORELINE_2023_SEGMENTED_PROJECT");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.DATE_).HasMaxLength(255);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_2023_SEGMEN_BUFFER>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D859CFA62BB");

            entity.ToTable("SHORELINE_2023_SEGMEN_BUFFER");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.BUFF_DIST).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_BASELINE>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D85A229DF90");

            entity.ToTable("SHORELINE_BASELINE");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.SHAPE_LENGTH1).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<SHORELINE_RATES_SEGMENTED_CLOSEST>(entity =>
        {
            entity.HasKey(e => e.OBJECTID).HasName("PK__SHORELIN__F4B70D852D18FE4E");

            entity.ToTable("SHORELINE_RATES_SEGMENTED_CLOSEST");

            entity.HasIndex(e => e.Shape, "FDO_Shape");

            entity.Property(e => e.AREA).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.BUFF_DIST).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.BaselineID).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.COUNT_).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.EPR).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.EPRunc).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.LCI).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.LR2).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.LRR).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.LSE).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.MEAN).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.NSM).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.ObjectID_12_13).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.SCE).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.Shape).HasColumnType("geometry");
            entity.Property(e => e.Shape_Length_1).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.ShrCount).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.TCD).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.TransEdit).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.TransOrder).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.TransectId).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.WCI).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.WLR).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.WR2).HasColumnType("numeric(38, 8)");
            entity.Property(e => e.WSE).HasColumnType("numeric(38, 8)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}