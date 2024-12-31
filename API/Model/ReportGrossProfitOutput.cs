using System;
using System.Collections.Generic;

namespace API.Model;

public partial class ReportGrossProfitOutput
{
    public int Id { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public double? Quantity15 { get; set; }

    public double? Density { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? CostOfGoodsSold { get; set; }

    public decimal? GrossProfit { get; set; }

    public double? PriceAverage { get; set; }

    public string? Description { get; set; }

    public string? Time { get; set; }
}
