using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogRetailPriceVolatility
{
    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public double? Price { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
