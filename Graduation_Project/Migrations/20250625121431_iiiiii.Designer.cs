﻿// <auto-generated />
using System;
using Graduation_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

#nullable disable

namespace Graduation_Project.Migrations
{
    [DbContext(typeof(Final_ProjectContext))]
    [Migration("20250625121431_iiiiii")]
    partial class iiiiii
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Graduation_Project.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Role_Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Graduation_Project.Models.BUILDING", b =>
                {
                    b.Property<int>("OBJECTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OBJECTID"));

                    b.Property<string>("ADDR_CITY")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ADDR_NUM")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ADDR_ST")
                        .HasMaxLength(91)
                        .HasColumnType("nvarchar(91)");

                    b.Property<string>("BLDG_TYPE")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("BLDG_USE")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<decimal?>("CENT_X")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("CENT_Y")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<string>("DIST_COAST")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ELEVATION")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<decimal?>("EST_OCCUP")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("EST_VALUE")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("HEIGHT")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("LEVELS")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<string>("NAME")
                        .HasMaxLength(92)
                        .HasColumnType("nvarchar(92)");

                    b.Property<decimal?>("PERIM_M")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<string>("STATUS")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<Geometry>("Shape")
                        .HasColumnType("geometry");

                    b.Property<decimal?>("VAL_USD_M2")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("VULN_SCORE")
                        .HasColumnType("numeric(38, 8)");

                    b.HasKey("OBJECTID")
                        .HasName("PK__BUILDING__F4B70D85C07A1108");

                    b.HasIndex(new[] { "Shape" }, "FDO_Shape");

                    b.ToTable("BUILDINGS", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.FINAL_TRANSECT", b =>
                {
                    b.Property<int>("OBJECTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OBJECTID"));

                    b.Property<decimal?>("Dt_To_Shoreline_2007")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("Dt_To_Shoreline_2013")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("Dt_To_Shoreline_2018")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("Dt_To_Shoreline_2023")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("EPR")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("EPRunc")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("LCI")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("LR2")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("LRR")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("LSE")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("NSM")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("SCE")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<Geometry>("Shape")
                        .HasColumnType("geometry");

                    b.Property<decimal?>("Shape_Length_1")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("ShrCount")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("TCD")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("TransectId")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<short?>("UNCERTAINTY")
                        .HasColumnType("smallint");

                    b.Property<decimal?>("WCI")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("WLR")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("WR2")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("WSE")
                        .HasColumnType("numeric(38, 8)");

                    b.HasKey("OBJECTID")
                        .HasName("PK__FINAL_TR__F4B70D85FD30F7B2");

                    b.HasIndex(new[] { "Shape" }, "FDO_Shape");

                    b.ToTable("FINAL_TRANSECT", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Role_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_1986_2023__PROJECT", b =>
                {
                    b.Property<int>("objectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectid"));

                    b.Property<string>("date_")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("merge_src")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Geometry>("shape")
                        .HasColumnType("geometry");

                    b.Property<short?>("uncertainty")
                        .HasColumnType("smallint");

                    b.HasKey("objectid")
                        .HasName("PK__SHORELIN__5242E6329345BDFF");

                    b.HasIndex(new[] { "shape" }, "FDO_shape");

                    b.ToTable("SHORELINE_1986_2023__PROJECT", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_1986_POINTS_100M", b =>
                {
                    b.Property<int>("objectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectid"));

                    b.Property<decimal?>("_base")
                        .HasColumnType("numeric(38, 8)")
                        .HasColumnName("base");

                    b.Property<short?>("altmode")
                        .HasColumnType("smallint");

                    b.Property<short?>("clamped")
                        .HasColumnType("smallint");

                    b.Property<short?>("extruded")
                        .HasColumnType("smallint");

                    b.Property<string>("folderpath")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<int?>("inline_fid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<int?>("orig_fid")
                        .HasColumnType("int");

                    b.Property<string>("popupinfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Geometry>("shape")
                        .HasColumnType("geometry");

                    b.Property<string>("snippet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("symbolid")
                        .HasColumnType("int");

                    b.HasKey("objectid")
                        .HasName("PK__SHORELIN__5242E6321E0FE271");

                    b.HasIndex(new[] { "shape" }, "FDO_shape");

                    b.ToTable("SHORELINE_1986_POINTS_100M", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_1986_SEGMENTED_PROJECT", b =>
                {
                    b.Property<int>("objectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectid"));

                    b.Property<string>("date_")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal?>("dt_to_shoreline_2007")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("dt_to_shoreline_2013")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("dt_to_shoreline_2018")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("dt_to_shoreline_2023")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<Geometry>("shape")
                        .HasColumnType("geometry");

                    b.Property<short?>("uncertainty")
                        .HasColumnType("smallint");

                    b.HasKey("objectid")
                        .HasName("PK__SHORELIN__5242E63201F0D9DF");

                    b.HasIndex(new[] { "shape" }, "FDO_shape");

                    b.ToTable("SHORELINE_1986_SEGMENTED_PROJECT", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_2007_POINTS_100M", b =>
                {
                    b.Property<int>("objectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectid"));

                    b.Property<decimal?>("_base")
                        .HasColumnType("numeric(38, 8)")
                        .HasColumnName("base");

                    b.Property<short?>("altmode")
                        .HasColumnType("smallint");

                    b.Property<short?>("clamped")
                        .HasColumnType("smallint");

                    b.Property<short?>("extruded")
                        .HasColumnType("smallint");

                    b.Property<string>("folderpath")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<int?>("inline_fid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<int?>("orig_fid")
                        .HasColumnType("int");

                    b.Property<string>("popupinfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Geometry>("shape")
                        .HasColumnType("geometry");

                    b.Property<string>("snippet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("symbolid")
                        .HasColumnType("int");

                    b.HasKey("objectid")
                        .HasName("PK__SHORELIN__5242E632FA102A4A");

                    b.HasIndex(new[] { "shape" }, "FDO_shape");

                    b.ToTable("SHORELINE_2007_POINTS_100M", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_2007_SEGMENTED_PROJECT", b =>
                {
                    b.Property<int>("objectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectid"));

                    b.Property<string>("date_")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Geometry>("shape")
                        .HasColumnType("geometry");

                    b.Property<short?>("uncertainty")
                        .HasColumnType("smallint");

                    b.HasKey("objectid")
                        .HasName("PK__SHORELIN__5242E63242FC7AA9");

                    b.HasIndex(new[] { "shape" }, "FDO_shape");

                    b.ToTable("SHORELINE_2007_SEGMENTED_PROJECT", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_2013_POINTS_100M", b =>
                {
                    b.Property<int>("objectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectid"));

                    b.Property<decimal?>("_base")
                        .HasColumnType("numeric(38, 8)")
                        .HasColumnName("base");

                    b.Property<short?>("altmode")
                        .HasColumnType("smallint");

                    b.Property<short?>("clamped")
                        .HasColumnType("smallint");

                    b.Property<short?>("extruded")
                        .HasColumnType("smallint");

                    b.Property<string>("folderpath")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<int?>("inline_fid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<int?>("orig_fid")
                        .HasColumnType("int");

                    b.Property<string>("popupinfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Geometry>("shape")
                        .HasColumnType("geometry");

                    b.Property<string>("snippet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("symbolid")
                        .HasColumnType("int");

                    b.HasKey("objectid")
                        .HasName("PK__SHORELIN__5242E6325B8CDE74");

                    b.HasIndex(new[] { "shape" }, "FDO_shape");

                    b.ToTable("SHORELINE_2013_POINTS_100M", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_2013_SEGMENTED_PROJECT", b =>
                {
                    b.Property<int>("objectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectid"));

                    b.Property<string>("date_")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Geometry>("shape")
                        .HasColumnType("geometry");

                    b.Property<short?>("uncertainty")
                        .HasColumnType("smallint");

                    b.HasKey("objectid")
                        .HasName("PK__SHORELIN__5242E6323116B3B0");

                    b.HasIndex(new[] { "shape" }, "FDO_shape");

                    b.ToTable("SHORELINE_2013_SEGMENTED_PROJECT", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_2018_POINTS_100M", b =>
                {
                    b.Property<int>("objectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectid"));

                    b.Property<decimal?>("_base")
                        .HasColumnType("numeric(38, 8)")
                        .HasColumnName("base");

                    b.Property<short?>("altmode")
                        .HasColumnType("smallint");

                    b.Property<short?>("clamped")
                        .HasColumnType("smallint");

                    b.Property<short?>("extruded")
                        .HasColumnType("smallint");

                    b.Property<string>("folderpath")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<int?>("inline_fid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<int?>("orig_fid")
                        .HasColumnType("int");

                    b.Property<string>("popupinfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Geometry>("shape")
                        .HasColumnType("geometry");

                    b.Property<string>("snippet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("symbolid")
                        .HasColumnType("int");

                    b.HasKey("objectid")
                        .HasName("PK__SHORELIN__5242E632AE009232");

                    b.HasIndex(new[] { "shape" }, "FDO_shape");

                    b.ToTable("SHORELINE_2018_POINTS_100M", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_2018_SEGMENTED_PROJECT", b =>
                {
                    b.Property<int>("objectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectid"));

                    b.Property<string>("date_")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Geometry>("shape")
                        .HasColumnType("geometry");

                    b.Property<short?>("uncertainty")
                        .HasColumnType("smallint");

                    b.HasKey("objectid")
                        .HasName("PK__SHORELIN__5242E632BC5E966C");

                    b.HasIndex(new[] { "shape" }, "FDO_shape");

                    b.ToTable("SHORELINE_2018_SEGMENTED_PROJECT", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_2023_AFTER", b =>
                {
                    b.Property<int>("OBJECTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OBJECTID"));

                    b.Property<string>("CVI_Classify")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<short?>("CVI_Rank")
                        .HasColumnType("smallint");

                    b.Property<string>("EPR_Category")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<short?>("EPR_Rank")
                        .HasColumnType("smallint");

                    b.Property<short?>("LRR_Erosion_Rank")
                        .HasColumnType("smallint");

                    b.Property<int?>("ORIG_SEQ")
                        .HasColumnType("int");

                    b.Property<Geometry>("Shape")
                        .HasColumnType("geometry");

                    b.Property<short?>("Slope_Rank")
                        .HasColumnType("smallint");

                    b.Property<short?>("Tidal_Rank")
                        .HasColumnType("smallint");

                    b.Property<short?>("Wave_Height_Rank")
                        .HasColumnType("smallint");

                    b.HasKey("OBJECTID")
                        .HasName("PK__SHORELIN__F4B70D855E9F4AC8");

                    b.HasIndex(new[] { "Shape" }, "FDO_Shape");

                    b.ToTable("SHORELINE_2023_AFTER", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_2023_CVI_1KM", b =>
                {
                    b.Property<int>("objectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectid"));

                    b.Property<string>("cvi_classify")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<short?>("cvi_rank")
                        .HasColumnType("smallint");

                    b.Property<string>("epr_category")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<short?>("epr_rank")
                        .HasColumnType("smallint");

                    b.Property<short?>("lrr_erosion_rank")
                        .HasColumnType("smallint");

                    b.Property<int?>("orig_seq")
                        .HasColumnType("int");

                    b.Property<Geometry>("shape")
                        .HasColumnType("geometry");

                    b.Property<short?>("slope_rank")
                        .HasColumnType("smallint");

                    b.Property<short?>("tidal_rank")
                        .HasColumnType("smallint");

                    b.Property<short?>("wave_height_rank")
                        .HasColumnType("smallint");

                    b.HasKey("objectid")
                        .HasName("PK__SHORELIN__5242E632B67F7F4E");

                    b.HasIndex(new[] { "shape" }, "FDO_shape");

                    b.ToTable("SHORELINE_2023_CVI_1KM", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_2023_POINTS_100M", b =>
                {
                    b.Property<int>("objectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectid"));

                    b.Property<decimal?>("coastal_slope")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("current_position_x")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("current_position_y")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("elevation")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("lrr")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("nsm")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("position_2030_x")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("position_2030_y")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("position_2035_x")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("position_2035_y")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("position_2040_x")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("position_2040_y")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("position_2045_x")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("position_2045_y")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("position_2050_x")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("position_2050_y")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("position_2100_x")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("position_2100_y")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("sea_level_rise_trend_mm_year")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<Geometry>("shape")
                        .HasColumnType("geometry");

                    b.HasKey("objectid")
                        .HasName("PK__SHORELIN__5242E632546A9592");

                    b.HasIndex(new[] { "shape" }, "FDO_shape");

                    b.ToTable("SHORELINE_2023_POINTS_100M", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_2023_POINTS_250M", b =>
                {
                    b.Property<int>("objectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectid"));

                    b.Property<decimal?>("_base")
                        .HasColumnType("numeric(38, 8)")
                        .HasColumnName("base");

                    b.Property<short?>("altmode")
                        .HasColumnType("smallint");

                    b.Property<short?>("clamped")
                        .HasColumnType("smallint");

                    b.Property<short?>("extruded")
                        .HasColumnType("smallint");

                    b.Property<string>("folderpath")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("inline_fid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("orig_fid")
                        .HasColumnType("int");

                    b.Property<string>("popupinfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Geometry>("shape")
                        .HasColumnType("geometry");

                    b.Property<string>("snippet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("symbolid")
                        .HasColumnType("int");

                    b.HasKey("objectid")
                        .HasName("PK__SHORELIN__5242E6320ACE28B5");

                    b.HasIndex(new[] { "shape" }, "FDO_shape");

                    b.ToTable("SHORELINE_2023_POINTS_250M", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_2023_SEGMENTED_PROJECT", b =>
                {
                    b.Property<int>("objectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectid"));

                    b.Property<string>("date_")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Geometry>("shape")
                        .HasColumnType("geometry");

                    b.Property<short?>("uncertainty")
                        .HasColumnType("smallint");

                    b.HasKey("objectid")
                        .HasName("PK__SHORELIN__5242E632AE2817F0");

                    b.HasIndex(new[] { "shape" }, "FDO_shape");

                    b.ToTable("SHORELINE_2023_SEGMENTED_PROJECT", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_2023_SEGMEN_BUFFER", b =>
                {
                    b.Property<int>("OBJECTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OBJECTID"));

                    b.Property<decimal?>("BUFF_DIST")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<int?>("InLine_FID")
                        .HasColumnType("int");

                    b.Property<int?>("ORIG_FID")
                        .HasColumnType("int");

                    b.Property<int?>("ORIG_SEQ")
                        .HasColumnType("int");

                    b.Property<Geometry>("Shape")
                        .HasColumnType("geometry");

                    b.HasKey("OBJECTID")
                        .HasName("PK__SHORELIN__F4B70D8510A6984E");

                    b.HasIndex(new[] { "Shape" }, "FDO_Shape");

                    b.ToTable("SHORELINE_2023_SEGMEN_BUFFER", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_BASELINE", b =>
                {
                    b.Property<int>("objectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("objectid"));

                    b.Property<int?>("id")
                        .HasColumnType("int");

                    b.Property<Geometry>("shape")
                        .HasColumnType("geometry");

                    b.Property<decimal?>("shape_length1")
                        .HasColumnType("numeric(38, 8)");

                    b.HasKey("objectid")
                        .HasName("PK__SHORELIN__5242E63231AE9FAC");

                    b.HasIndex(new[] { "shape" }, "FDO_shape");

                    b.ToTable("SHORELINE_BASELINE", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.SHORELINE_RATES_SEGMENTED_CLOSEST", b =>
                {
                    b.Property<int>("OBJECTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OBJECTID"));

                    b.Property<decimal?>("AREA")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("BUFF_DIST")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("BaselineID")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("COUNT_")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("EPR")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("EPRunc")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<int?>("InLine_FID")
                        .HasColumnType("int");

                    b.Property<int?>("Join_Count")
                        .HasColumnType("int");

                    b.Property<decimal?>("LCI")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("LR2")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("LRR")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("LSE")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("MEAN")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("NSM")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<int?>("OBJECTID_1")
                        .HasColumnType("int");

                    b.Property<int?>("OBJECTID_12")
                        .HasColumnType("int");

                    b.Property<int?>("ORIG_FID")
                        .HasColumnType("int");

                    b.Property<int?>("ORIG_SEQ")
                        .HasColumnType("int");

                    b.Property<decimal?>("ObjectID_12_13")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("SCE")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<Geometry>("Shape")
                        .HasColumnType("geometry");

                    b.Property<decimal?>("Shape_Length_1")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("ShrCount")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<int?>("TARGET_FID")
                        .HasColumnType("int");

                    b.Property<decimal?>("TCD")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("TransEdit")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("TransOrder")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("TransectId")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("WCI")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("WLR")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("WR2")
                        .HasColumnType("numeric(38, 8)");

                    b.Property<decimal?>("WSE")
                        .HasColumnType("numeric(38, 8)");

                    b.HasKey("OBJECTID")
                        .HasName("PK__SHORELIN__F4B70D850BAAAE51");

                    b.HasIndex(new[] { "Shape" }, "FDO_Shape");

                    b.ToTable("SHORELINE_RATES_SEGMENTED_CLOSEST", (string)null);
                });

            modelBuilder.Entity("Graduation_Project.Models.UserLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Account_Id")
                        .HasColumnType("int");

                    b.Property<Geometry>("shape")
                        .IsRequired()
                        .HasColumnType("geography");

                    b.HasKey("Id");

                    b.HasIndex("Account_Id");

                    b.ToTable("UserLocations");
                });

            modelBuilder.Entity("Graduation_Project.Models.Account", b =>
                {
                    b.HasOne("Graduation_Project.Models.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("Role_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Graduation_Project.Models.UserLocation", b =>
                {
                    b.HasOne("Graduation_Project.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("Account_Id");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Graduation_Project.Models.Role", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
