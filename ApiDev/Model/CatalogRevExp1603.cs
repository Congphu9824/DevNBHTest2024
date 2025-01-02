using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogRevExp1603
{
    public string CodeRevExp { get; set; } = null!;

    public string? GrpCode { get; set; }

    public string? GrpName { get; set; }

    public string? NameRevExp { get; set; }

    public string TypeRevExp { get; set; } = null!;

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public bool ByObject { get; set; }
}
