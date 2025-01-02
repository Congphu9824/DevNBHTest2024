using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogProductionShift
{
    public string CodeShift { get; set; } = null!;

    public string? NameShift { get; set; }

    public Guid Id { get; set; }

    public bool IsActive { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }
}
