using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SalesDataInventoryDocumment
{
    public Guid Id { get; set; }

    public string? DataType { get; set; }

    public string? NumberOfVouchers { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? WarehoseData { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? CommodityCode { get; set; }

    public double? Quantity { get; set; }

    public double? Quantity15 { get; set; }
}
