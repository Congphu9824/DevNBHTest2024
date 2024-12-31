using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogGroupProduct
{
    public string GroupCode { get; set; } = null!;

    public string? GroupName { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public bool IsActive { get; set; }

    public string? Note { get; set; }

    public bool IsGem { get; set; }
}
