using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SalesMaterialRemaining
{
    public string? AccountSymbol { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? PumpColumnCode { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public string? UnitPackage { get; set; }

    public double? ConversionFactor { get; set; }

    public double? PackageQuantity { get; set; }

    public double? QuantityOfInventory { get; set; }

    public double? Quantity { get; set; }

    public double? Quantity15 { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public Guid? IdData { get; set; }

    public string? WarehoseData { get; set; }

    public string? CodeSupplier { get; set; }

    public string? NameSupplier { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ShipmentNumber { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }
}
