using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class ViewSalesDataImpExp
{
    public int? CodeUnit { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? DataType { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? ReasonCode { get; set; }

    public string? CommodityCode { get; set; }

    public double? Quantity { get; set; }

    public decimal? AmountAfterDiscount { get; set; }
}
