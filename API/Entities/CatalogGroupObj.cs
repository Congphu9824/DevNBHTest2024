using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogGroupObj
{
    public string CodeGroupObj { get; set; } = null!;

    public string? NameGroupObj { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }
}
