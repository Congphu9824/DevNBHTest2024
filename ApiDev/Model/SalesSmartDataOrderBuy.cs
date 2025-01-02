using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SalesSmartDataOrderBuy
{
    public string? DataType { get; set; }

    public DateTime? RecordDate { get; set; }

    public int? CodeUnit { get; set; }

    public string? ReasonCode { get; set; }

    public string? CommodityCode { get; set; }

    public double? Quantity { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? WarehoseCode { get; set; }

    public string? CommodityName { get; set; }

    public Guid IdSource { get; set; }
}
