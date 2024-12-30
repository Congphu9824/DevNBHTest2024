using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogGroupContract
{
    public string GrpCode { get; set; } = null!;

    public string? GrpName { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }
}
