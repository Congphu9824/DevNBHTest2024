using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogPurposeOfUse
{
    public string PurposeCode { get; set; } = null!;

    public string? PurposeName { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public bool? IsActive { get; set; }

    public int IdAsc { get; set; }

    public Guid Id { get; set; }
}
