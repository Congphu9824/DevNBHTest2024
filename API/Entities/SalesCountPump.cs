using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SalesCountPump
{
    public string? WarehoseData { get; set; }

    public string? DataType { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string PumpColumnCode { get; set; } = null!;

    public string? CommodityCode { get; set; }

    public double? NumberEnd { get; set; }
}
