using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class ReportAccountDetailsBook
{
    public int Id { get; set; }

    public int? NumericalOrderPrint { get; set; }

    public int? NumericalOrder { get; set; }

    public int? MaxNumericalOrder { get; set; }

    public string? SmartSort { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public string? DataType { get; set; }

    public Guid? IdVoucher { get; set; }

    public string? ForeignCurrencyType { get; set; }

    public decimal? ExchangeRate { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? VoucherDate { get; set; }

    public bool? NoExcel { get; set; }

    public string? TaxCode { get; set; }

    public string? DayBefore { get; set; }

    public string? NextDay { get; set; }

    public string? EndDate { get; set; }

    public string? BeginDate { get; set; }

    public string? Date { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? Description { get; set; }

    public string? Note { get; set; }

    public string? Note1 { get; set; }

    public string? Note2 { get; set; }

    public string? Note3 { get; set; }

    public string? Note4 { get; set; }

    public string? Note5 { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Price { get; set; }

    public double? Quantity { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? AccountSymbol { get; set; }

    public string? AccountName { get; set; }

    public int? AccountLevel { get; set; }

    public decimal? DebitBalance { get; set; }

    public decimal? DebtBalancBegin { get; set; }

    public decimal? CreditBalancBegin { get; set; }

    public decimal? DebtArise { get; set; }

    public decimal? CreditArise { get; set; }

    public decimal? DebtBalancRemaining { get; set; }

    public decimal? CreditBalancRemaining { get; set; }

    public decimal? DebtBalancEnd { get; set; }

    public decimal? CreditBalancEnd { get; set; }

    public decimal? DebitBalanceUsd { get; set; }

    public decimal? DebtBalancBeginUsd { get; set; }

    public decimal? CreditBalancBeginUsd { get; set; }

    public decimal? DebtAriseUsd { get; set; }

    public decimal? CreditAriseUsd { get; set; }

    public decimal? DebtBalancRemainingUsd { get; set; }

    public decimal? CreditBalancRemainingUsd { get; set; }

    public decimal? DebtBalancEndUsd { get; set; }

    public decimal? CreditBalancEndUsd { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
