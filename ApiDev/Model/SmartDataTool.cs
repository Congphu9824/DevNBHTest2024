using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SmartDataTool
{
    public string? DataType { get; set; }

    public bool Delivered { get; set; }

    public string? DataName { get; set; }

    public bool? CostAllotment { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public bool Einvoice { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public decimal? CarryingAmount { get; set; }

    public double? DepreciationPeriod { get; set; }

    public double? DepreciationValuePerMonth { get; set; }

    public decimal? AccumulatedDepreciation { get; set; }

    public double? DepreciatedTime { get; set; }

    public double? RemainingAmortizationPeriod { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? NumberOfVouchersContenst { get; set; }

    public DateTime? AllocationDate { get; set; }

    public string? Notes { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDateContenst { get; set; }

    public Guid Id { get; set; }
}
