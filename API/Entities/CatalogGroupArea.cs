using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogGroupArea
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string CodeGroupArea { get; set; } = null!;

    public string? NameGroupArea { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
