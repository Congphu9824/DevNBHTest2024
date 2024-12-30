using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class ViewDataCompareRemainder
{
    public int? CodeUnit { get; set; }

    public string? WarehoseCode { get; set; }

    public string? CommodityCode { get; set; }

    public double? QuantityBegin { get; set; }
}
