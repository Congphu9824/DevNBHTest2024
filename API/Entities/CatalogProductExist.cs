using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogProductExist
{
    public string ProductCode { get; set; } = null!;

    public string? ProductName { get; set; }

    public string? UnitPsc { get; set; }

    public double? PriceImp { get; set; }

    public double? PriceExp { get; set; }

    public double? PriceRetail { get; set; }

    public double? VatRate { get; set; }

    public string? TypeVat { get; set; }

    public string? GrpCode { get; set; }

    public string? GrpName { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? CodeSupplier { get; set; }

    public string? NameSupplier { get; set; }
}
