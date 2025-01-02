using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SmartListOfTool
{
    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public Guid? IdData { get; set; }

    public string? DataType { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? CarryingAmount { get; set; }

    public double? DepreciationPeriod { get; set; }

    public double? DepreciationValuePerMonth { get; set; }

    public decimal? AccumulatedDepreciation { get; set; }

    public double? DepreciatedTime { get; set; }

    public double? RemainingAmortizationPeriod { get; set; }

    public decimal? RemainingAmortization { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? Description { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public DateTime? AllocationDate { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? RevenueExpenseCode { get; set; }

    public string? RevenueExpenseName { get; set; }

    public string? ConstructionCode { get; set; }

    public string? ConstructionName { get; set; }

    public string? ProjectCode { get; set; }

    public string? ProjectName { get; set; }

    public string? RoomCode { get; set; }

    public string? RoomName { get; set; }

    public string? ProductionActivitieCode { get; set; }

    public string? ProductionActivitieName { get; set; }

    public string? FundingSourceCode { get; set; }

    public string? FundingSourceName { get; set; }

    public string? Notes { get; set; }

    public string? Loaiphieu { get; set; }

    public Guid? IdSource { get; set; }
}
