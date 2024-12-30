using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class DeleteSalesSmartProductInventory
{
    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public double? Quantity15 { get; set; }

    public double? CoefficientVcf { get; set; }

    public double? Temperature { get; set; }

    public double? CoefficientWcf { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public string? Loaiphieu { get; set; }
}
