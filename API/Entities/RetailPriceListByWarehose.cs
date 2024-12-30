using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class RetailPriceListByWarehose
{
    public string? WarehoseCode { get; set; }

    public string ColumnCode { get; set; } = null!;

    public string? ColumnName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Price { get; set; }

    public double? VatRate { get; set; }

    public double? EnvironmentalProtectionFee { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public int IdAsc { get; set; }
}
