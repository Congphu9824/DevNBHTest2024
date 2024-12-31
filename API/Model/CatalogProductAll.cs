using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogProductAll
{
    public string ProductCode { get; set; } = null!;

    public string? ProductName { get; set; }

    public string? UnitPsc { get; set; }

    public string? UnitPackage { get; set; }

    public double? Conversion { get; set; }

    public double? ProNumberInSlot { get; set; }

    public double? Density { get; set; }

    public string? Description { get; set; }

    public string? Brand { get; set; }

    public double? PriceImp { get; set; }

    public double? PriceExp { get; set; }

    public double? PriceRetail { get; set; }

    public double? EnvironmentalProtectionFee { get; set; }

    public double? VatRate { get; set; }

    public string? TypeVat { get; set; }

    public string? AccMaterial { get; set; }

    public string? AccCostOfCapital { get; set; }

    public string? AccRevenue { get; set; }

    public string? AccountSymbol { get; set; }

    public string? GrpCode { get; set; }

    public string? GrpName { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? Notes { get; set; }

    public bool GreaseOil { get; set; }

    public string? Pictures { get; set; }

    public bool IsActive { get; set; }

    public int CodeUnit { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }

    public string? ProductCodeFts { get; set; }

    public bool FinishedProduct { get; set; }

    public double? Discount1 { get; set; }

    public double? Discount2 { get; set; }

    public double? Discount3 { get; set; }

    public double? Discount4 { get; set; }

    public double? SurplusMaximum { get; set; }

    public double? SurplusMinimum { get; set; }

    public Guid Id { get; set; }

    public string? Barcode { get; set; }

    public string? CodeSupplier { get; set; }

    public string? NameSupplier { get; set; }

    public DateTime? RecordDate { get; set; }

    public string NumberOfVouchers { get; set; } = null!;

    public int Quantity { get; set; }

    public int AmountOfMoney { get; set; }

    public string DataType { get; set; } = null!;

    public string WarehoseData { get; set; } = null!;
}
