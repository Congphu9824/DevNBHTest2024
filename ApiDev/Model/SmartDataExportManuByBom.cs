using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SmartDataExportManuByBom
{
    public Guid IdSource { get; set; }

    public Guid IdRequire { get; set; }

    public string? DataType { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public double? QuantityProduct { get; set; }

    public string? UnitPcs { get; set; }

    public double? QuantityBom { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public double? AmountOfMoney { get; set; }

    public string Description { get; set; } = null!;
}
