using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogFundingSource
{
    public string FundingSourceCode { get; set; } = null!;

    public string FundingSourceName { get; set; } = null!;

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }
}
