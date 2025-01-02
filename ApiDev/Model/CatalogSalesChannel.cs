using System;
using System.Collections.Generic;

namespace ApiDev.Model;

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
