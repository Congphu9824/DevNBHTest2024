using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogImpExpReason
{
    public string CodeReason { get; set; } = null!;

    public string? NameReason { get; set; }

    public string? TypeReason { get; set; }

    public string? MethodOfPayments { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public bool IsSales { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public int IdAsc { get; set; }

    public string? DataTypeUse { get; set; }
}
