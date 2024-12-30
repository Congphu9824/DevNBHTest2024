using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogBranch
{
    public string BranchCode { get; set; } = null!;

    public string? BranchName { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public int IdAsc { get; set; }

    public Guid Id { get; set; }
}
