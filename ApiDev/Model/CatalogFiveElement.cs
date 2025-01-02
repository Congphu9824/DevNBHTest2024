using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogFiveElement
{
    public string CodeFiveElements { get; set; } = null!;

    public string? NameFiveElements { get; set; }

    public Guid Id { get; set; }

    public bool IsActive { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }
}
