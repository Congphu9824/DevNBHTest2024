using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogThickness
{
    public string CodeThickness { get; set; } = null!;

    public string? NameThickness { get; set; }

    public Guid Id { get; set; }

    public bool IsActive { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }
}
