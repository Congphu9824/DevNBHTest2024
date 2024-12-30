using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SalesSmartDataOrderBuyUneven
{
    public int? CodeUnit { get; set; }

    public string? ReasonCode { get; set; }

    public string? CommodityCode { get; set; }

    public string? WarehoseCode { get; set; }

    public double? Quantity { get; set; }
}
