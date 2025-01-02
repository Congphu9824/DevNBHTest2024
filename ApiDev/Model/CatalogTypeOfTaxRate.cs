using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogTypeOfTaxRate
{
    public string TypeCode { get; set; } = null!;

    public string? TypeName { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public double? VatRate { get; set; }
}
