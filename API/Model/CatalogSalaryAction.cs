using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogSalaryAction
{
    public string CodeSalaryAction { get; set; } = null!;

    public string? NameSalaryAction { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public string? TypeAction { get; set; }
}
