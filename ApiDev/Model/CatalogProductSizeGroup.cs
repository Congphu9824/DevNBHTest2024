using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogProductSizeGroup
{
    public string? SizeCode { get; set; }

    public string? SizeName { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
