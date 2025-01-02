using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogProvince
{
    public string CodeProvince { get; set; } = null!;

    public string? NameProvince { get; set; }

    public string CodeArea { get; set; } = null!;

    public string? NameArea { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }
}
