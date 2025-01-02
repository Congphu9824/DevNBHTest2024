﻿using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class ExcelCatalogProduct
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

    public string? NameSupplier { get; set; }

    public string? CodeSupplier { get; set; }

    public string? ColorCode { get; set; }

    public string? ColorName { get; set; }

    public string? Notes { get; set; }

    public bool GreaseOil { get; set; }

    public string? Pictures { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }

    public string? ProductCodeFts { get; set; }

    public bool FinishedProduct { get; set; }

    public string? BarCode { get; set; }

    public double? Discount1 { get; set; }

    public double? Discount2 { get; set; }

    public double? Discount3 { get; set; }

    public double? Discount4 { get; set; }

    public double? SurplusMaximum { get; set; }

    public double? SurplusMinimum { get; set; }

    public double? PercentExp { get; set; }

    public double? PercentRetail { get; set; }

    public double? RetailPrice { get; set; }

    public double? ExciseTaxRate { get; set; }

    public DateTime CreateDate { get; set; }

    public double? CoefficientVcf { get; set; }

    public bool EnviromentByKg { get; set; }

    public string? NumberImport { get; set; }

    public bool IsCreated { get; set; }

    public string? DataType { get; set; }

    public string? AddressSupplier { get; set; }

    public string? ShortNameSupplier { get; set; }

    public string? ShortAddressSupplier { get; set; }

    public string? Origin { get; set; }

    public string? TypeData { get; set; }

    public string? CreateBy { get; set; }

    public string? CodeWarehose { get; set; }

    public string? NameWarehose { get; set; }

    public string? GenderCode { get; set; }

    public string? GenderName { get; set; }

    public string? MaterialCode { get; set; }

    public string? MaterialName { get; set; }

    public string? QualityTeamCode { get; set; }

    public string? QualityTeamName { get; set; }

    public string? SizeCode { get; set; }

    public string? SizeName { get; set; }
}
