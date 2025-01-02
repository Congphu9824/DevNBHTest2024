using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class RemainingQuantityManufacetureSortMetal
{
    public int? CodeUnit { get; set; }

    public Guid? IdSource { get; set; }

    public string? StageCode { get; set; }

    public string? ProductCode { get; set; }

    public string? CommodityCode { get; set; }

    public double? ProductionQuantity { get; set; }
}
