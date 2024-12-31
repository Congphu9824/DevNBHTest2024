using System;
using System.Collections.Generic;

namespace API.Model;

public partial class ReportGrossProfit
{
    public int Id { get; set; }

    public int? NumericalOrder { get; set; }

    public int? MaxNumericalOrder { get; set; }

    public string? SmartSort { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public bool? NoExcel { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? Address { get; set; }

    public string? TargetCode { get; set; }

    public string? TargetName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Price { get; set; }

    public double? Quantity { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? AccountSymbol { get; set; }

    public string? AccountName { get; set; }

    public int? AccountLevel { get; set; }

    public decimal? BeginBalanc { get; set; }

    public decimal? TurnoverArise { get; set; }

    public decimal? CostArise { get; set; }

    public decimal? ProfitMoney { get; set; }

    public decimal? EndingBalance { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
