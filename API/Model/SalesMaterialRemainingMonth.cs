using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SalesMaterialRemainingMonth
{
    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? MonthText { get; set; }

    public double? QuantityLose { get; set; }

    public double? QuantityLose15 { get; set; }

    public double? QuantityAverage { get; set; }

    public double? QuantityAverage15 { get; set; }

    public double? InventorySurplus { get; set; }

    public string? UnitPcs { get; set; }

    public string? UnitPackage { get; set; }

    public double? ConversionFactor { get; set; }

    public double? PackageQuantity { get; set; }

    public double? QuantityOfInventory { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public Guid? IdData { get; set; }

    public string? WarehoseData { get; set; }
}
