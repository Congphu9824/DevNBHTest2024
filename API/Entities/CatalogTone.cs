using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogTone
{
    public string CodeTone { get; set; } = null!;

    public string? NameTone { get; set; }

    public string? ColorRgb { get; set; }

    public string? ColorHex { get; set; }

    public string? ColorName { get; set; }

    public Guid Id { get; set; }

    public bool IsActive { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }
}
