using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogSalaryType
{
    public string CodeSalaryType { get; set; } = null!;

    public string? NameSalaryType { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
