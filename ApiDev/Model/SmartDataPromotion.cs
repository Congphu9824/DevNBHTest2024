using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SmartDataPromotion
{
    public int? CodeUnit { get; set; }

    public string? ProgramCode { get; set; }

    public string? FormOfPromotionCode { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? WarehoseCode { get; set; }

    public string? CommodityCode { get; set; }

    public double? DiscountRate { get; set; }
}
