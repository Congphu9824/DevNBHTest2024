using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SmartProductionDataSortMetal
{
    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public Guid IdSource { get; set; }

    public string? DataType { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? WarehoseData { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string StageCode { get; set; } = null!;

    public string? Stagename { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? QuantityRequire { get; set; }

    public double? ProductionQuantity { get; set; }

    public string? Notes { get; set; }
}
