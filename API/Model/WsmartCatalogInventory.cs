using System;
using System.Collections.Generic;

namespace API.Model;

public partial class WsmartCatalogInventory
{
    public int Id { get; set; }

    public int? CodeUnit { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? Barcode { get; set; }

    public string? UnitPcs { get; set; }

    public double? InStock { get; set; }

    public double? RetailPrice { get; set; }

    public string? MonthCode { get; set; }

    public string? MonthName { get; set; }

    public int? Year { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? GrpCode { get; set; }

    public string? GrpName { get; set; }

    public string? Notes { get; set; }

    public DateTime CreateDate { get; set; }

    public int? SapoProductId { get; set; }

    public int? SapoVariantId { get; set; }

    public int? SapoLocationId { get; set; }
}
