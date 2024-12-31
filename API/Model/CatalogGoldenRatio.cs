using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogGoldenRatio
{
    public string CodeGoldenRatio { get; set; } = null!;

    public string? NameGoldenRatio { get; set; }

    public Guid Id { get; set; }

    public bool IsActive { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public double? Ratio { get; set; }
}
