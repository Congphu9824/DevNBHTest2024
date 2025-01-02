using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SmartDataExportByBom
{
    public Guid IdSource { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public double? AmountOfMoney { get; set; }

    public string DebitSide { get; set; } = null!;

    public string CreditSide { get; set; } = null!;

    public string AccountSymbol { get; set; } = null!;

    public string Description { get; set; } = null!;
}
