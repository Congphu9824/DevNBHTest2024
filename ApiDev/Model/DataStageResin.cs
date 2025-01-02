using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class DataStageResin
{
    public Guid Id { get; set; }

    public int? CodeUnit { get; set; }

    public string? DataType { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? VoucherDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? PersonCode { get; set; }

    public string? PersonName { get; set; }

    public Guid? IdData { get; set; }

    public Guid IdSource { get; set; }

    public string? StageCode { get; set; }

    public string? StageName { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public double? Quantity { get; set; }

    public double? QuantityInven { get; set; }

    public double? Weight { get; set; }

    public string? Description { get; set; }
}
