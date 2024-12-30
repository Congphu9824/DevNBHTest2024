using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogSalesChannel
{
    public string SalesChannelCode { get; set; } = null!;

    public string? SalesChannelName { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }
}
