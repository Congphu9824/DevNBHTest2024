using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogChosePrint
{
    public Guid Id { get; set; }

    public string? ChosePrint { get; set; }

    public string? TypeNameReport { get; set; }

    public bool IsActive { get; set; }

    public string? Subsystem { get; set; }

    public int IdAsc { get; set; }
}
