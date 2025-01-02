using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogGroupContract1603
{
    public string GrpCode { get; set; } = null!;

    public string? GrpName { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }
}
