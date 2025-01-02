using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class ViewDataCompareImp
{
    public int? CodeUnit { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? WarehoseCode { get; set; }

    public string? CommodityCode { get; set; }

    public double? QuantityImp { get; set; }
}
