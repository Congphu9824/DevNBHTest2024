using System;
using System.Collections.Generic;

namespace API.Model;

public partial class BusinessPriceList
{
    public int? CodeUnit { get; set; }

    public Guid IdContents { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? PriceArea1 { get; set; }

    public double? DiscountRateArea1 { get; set; }

    public double? PriceArea2 { get; set; }

    public double? DiscountRateArea2 { get; set; }

    public double? FeeEnvironRate { get; set; }

    public double? VatRate { get; set; }

    public string? DecisionNo { get; set; }

    public int? BeginHour { get; set; }

    public DateTime? BeginDate { get; set; }

    public int? EndHour { get; set; }

    public DateTime? EndDate { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }
}
