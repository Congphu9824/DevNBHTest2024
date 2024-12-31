using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogFuntion
{
    public string Module { get; set; } = null!;

    public string? FuntionLevel { get; set; }

    public string FuntionCode { get; set; } = null!;

    public string? FuntionName { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }
}
