using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogTypeReport
{
    public Guid Id { get; set; }

    public string? TypeReport { get; set; }

    public string? TypeNameReport { get; set; }

    public bool IsActive { get; set; }

    public string? Subsystem { get; set; }

    public int IdAsc { get; set; }
}
