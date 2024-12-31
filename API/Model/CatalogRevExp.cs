using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogRevExp
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

    public bool ByBank { get; set; }

    public bool ByTransfer { get; set; }
}
