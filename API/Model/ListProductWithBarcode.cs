using System;
using System.Collections.Generic;

namespace API.Model;

public partial class ListProductWithBarcode
{
    public string ProductCode { get; set; } = null!;

    public string? Barcode { get; set; }

    public string? ProductName { get; set; }

    public string? UnitPsc { get; set; }

    public int QuantityOfInventory { get; set; }

    public double? PriceRetail { get; set; }

    public double? PriceExp { get; set; }

    public double? PriceImp { get; set; }

    public double? VatRate { get; set; }

    public string? TypeVat { get; set; }

    public string? TypeCode { get; set; }

    public string? NameSupplier { get; set; }

    public string? CodeSupplier { get; set; }

    public string? Notes { get; set; }

    public int IdAsc { get; set; }

    public Guid Id { get; set; }

    public bool NoAccumulationPoint { get; set; }

    public double Quantity15 { get; set; }

    public double? DiscountRate { get; set; }
}
