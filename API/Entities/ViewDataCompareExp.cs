﻿using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class ViewDataCompareExp
{
    public int? CodeUnit { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? WarehoseCode { get; set; }

    public string? CommodityCode { get; set; }

    public double? QuantityExp { get; set; }
}