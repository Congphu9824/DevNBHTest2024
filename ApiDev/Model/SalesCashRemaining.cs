using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SalesCashRemaining
{
    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public double? PackageQuantity { get; set; }

    public double? QuantityOfInventory { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }
}
