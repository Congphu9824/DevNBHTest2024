using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class RemainingQuantityManufaceture
{
    public int? CodeUnit { get; set; }

    public Guid? IdSource { get; set; }

    public string? StageCode { get; set; }

    public string? ProductCode { get; set; }

    public string? CommodityCode { get; set; }

    public double? ProductionQuantity { get; set; }
}
