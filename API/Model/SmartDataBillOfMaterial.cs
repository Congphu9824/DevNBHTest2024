using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SmartDataBillOfMaterial
{
    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? QuantityProduct { get; set; }

    public double? QuantityBom { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public string? Notes { get; set; }

    public string? DataType { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public Guid IdSource { get; set; }

    public bool IsKit { get; set; }
}
