using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogServiceProduct
{
    public string? ServiceCode { get; set; }

    public string? ServiceName { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
