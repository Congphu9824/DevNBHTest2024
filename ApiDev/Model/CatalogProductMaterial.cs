using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogProductMaterial
{
    public string? MaterialCode { get; set; }

    public string? MaterialName { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
