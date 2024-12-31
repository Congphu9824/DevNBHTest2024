using System;
using System.Collections.Generic;

namespace API.Model;

public partial class DataWaitingForAllocation
{
    public bool IsActive { get; set; }

    public bool? CostAllotment { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? Description { get; set; }

    public string? CreditObjectCode { get; set; }

    public string? CreditObjectName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public double? Quantity { get; set; }

    public decimal? AmountOfMoney { get; set; }
}
