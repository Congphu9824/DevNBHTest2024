using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogProductType
{
    public string ProductTypeCode { get; set; } = null!;

    public string? ProductTypeName { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public bool IsActive { get; set; }

    public bool NoAccumulationPoint { get; set; }

    public string? SignType { get; set; }
}
