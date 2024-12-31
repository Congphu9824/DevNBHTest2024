using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogArea
{
    public string? GrpCodeArea { get; set; }

    public string? GrpNameArea { get; set; }

    public string CodeArea { get; set; } = null!;

    public string? NameArea { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
