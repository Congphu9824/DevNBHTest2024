using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class DataAdminAllotmentAssetTool
{
    public int Id { get; set; }

    public Guid? Identifier { get; set; }

    public string? UserCode { get; set; }

    public string? DataType { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public int? Ordinal { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? NumberOfVouchers { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? AllocationDate { get; set; }

    public DateTime? AllocationDateEnd { get; set; }

    public DateTime? AllocationDateBegin { get; set; }

    public DateTime? VoucherDate { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? ProjectCode { get; set; }

    public string? ProjectName { get; set; }

    public string? ProductionActivitieCode { get; set; }

    public string? ProductionActivitieName { get; set; }

    public string? RevenueExpenseCode { get; set; }

    public string? RevenueExpenseName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? DebitObjectCode { get; set; }

    public string? DebitObjectName { get; set; }

    public string? CreditObjectCode { get; set; }

    public string? CreditObjectName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Price { get; set; }

    public int? Quantity { get; set; }

    public decimal? AmountRules { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public int? DepreciationPeriod { get; set; }

    public decimal? DepreciationValuePerMonth { get; set; }

    public decimal? ValuePerMonthRules { get; set; }

    public decimal? AccumulatedDepreciation { get; set; }

    public int? DepreciatedTime { get; set; }

    public decimal? DepreciationCalueForThisPeriod { get; set; }

    public decimal? DepreciationCalueForThisPeriodRules { get; set; }

    public decimal? ValueNotValid { get; set; }

    public int? DepreciationPeriodForThisPeriod { get; set; }

    public decimal? RemainingAmortization { get; set; }

    public int? RemainingAmortizationPeriod { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Description { get; set; }

    public string? Time { get; set; }
}
