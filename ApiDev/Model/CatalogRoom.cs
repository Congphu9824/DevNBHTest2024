using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogRoom
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string CodeRoom { get; set; } = null!;

    public string? NameRoom { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
