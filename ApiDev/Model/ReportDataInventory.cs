using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class ReportDataInventory
{
    public int Id { get; set; }

    public string? UserCode { get; set; }

    public string? IdVoucher { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? CodeSupplier { get; set; }

    public string? NameSupplier { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public bool IsExists { get; set; }

    public double? PriceImp { get; set; }

    public double? PriceExp { get; set; }

    public double? PriceRetail { get; set; }

    public double? Quantity { get; set; }

    public string? Time { get; set; }
}
