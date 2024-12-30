using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SmartDataFinalAdjustment
{
    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? UserCode { get; set; }

    public string? WarehoseCode { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public decimal? AmountOfMoney { get; set; }
}
