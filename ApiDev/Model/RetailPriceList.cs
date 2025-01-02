using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class RetailPriceList
{
    public Guid Id { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

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
