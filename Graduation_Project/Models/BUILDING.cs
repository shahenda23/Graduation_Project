﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Graduation_Project.Models;

public partial class BUILDING
{
    public int OBJECTID { get; set; }

    public Geometry Shape { get; set; }

    public string BLDG_TYPE { get; set; }

    public string BLDG_USE { get; set; }

    public decimal? HEIGHT { get; set; }

    public decimal? LEVELS { get; set; }

    public string ADDR_CITY { get; set; }

    public string ADDR_ST { get; set; }

    public string ADDR_NUM { get; set; }

    public string NAME { get; set; }

    public string STATUS { get; set; }

    public decimal? PERIM_M { get; set; }

    public decimal? CENT_X { get; set; }

    public decimal? CENT_Y { get; set; }

    public decimal? VAL_USD_M2 { get; set; }

    public decimal? EST_VALUE { get; set; }

    public decimal? VULN_SCORE { get; set; }

    public decimal? EST_OCCUP { get; set; }

    public string DIST_COAST { get; set; }

    public string ELEVATION { get; set; }
}