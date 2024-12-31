using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogLocationPublishInv
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Taxcode { get; set; }

    public string? LoacationName { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
