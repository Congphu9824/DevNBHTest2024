using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SmartListProductByBarcode
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string ProductCode { get; set; } = null!;

    public string Barcode { get; set; } = null!;

    public string? ProductName { get; set; }

    public string? UnitPsc { get; set; }

    public double? VatRate { get; set; }

    public int QuantityOfInventory { get; set; }

    public double? PriceImp { get; set; }

    public double? PriceExp { get; set; }

    public double? PriceRetail { get; set; }

    public string? TypeVat { get; set; }

    public string? UnitPackage { get; set; }

    public double? Conversion { get; set; }

    public double? Discount1 { get; set; }

    public double? Discount2 { get; set; }

    public double? Discount3 { get; set; }

    public double? Discount4 { get; set; }

    public string? NameSupplier { get; set; }

    public string? CodeSupplier { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? GrpCode { get; set; }

    public string? GrpName { get; set; }

    public int NoAccumulationPoint { get; set; }

    public string? Notes { get; set; }
}
