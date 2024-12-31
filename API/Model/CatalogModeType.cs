using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogModeType
{
    public string CodeModeType { get; set; } = null!;

    public string? NameModeType { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
