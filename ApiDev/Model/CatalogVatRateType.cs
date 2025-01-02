using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogVatRateType
{
    public string? VatRateTypeCode { get; set; }

    public string? VatRateTypeName { get; set; }

    public string? TypeVatRate { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public double? VatRate { get; set; }
}
