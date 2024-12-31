using System;
using System.Collections.Generic;

namespace API.Model;

public partial class ReportDebtSummaryBook
{
    public int Id { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public string? ForeignCurrencyType { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? HeadofDepartment { get; set; }

    public string? HeadofShifts { get; set; }

    public string? PositionAcc { get; set; }

    public string? AccName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? GroupAreaCode { get; set; }

    public string? GroupAreaName { get; set; }

    public string? AreaCode { get; set; }

    public string? AreaName { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? Address { get; set; }

    public string? AccountNumber { get; set; }

    public string? BankName { get; set; }

    public string? AccountSymbol { get; set; }

    public string? AccountName { get; set; }

    public int? AccountLevel { get; set; }

    public decimal? DebitBalance { get; set; }

    public decimal? DebitLetterOfGuarantee { get; set; }

    public decimal? DebitHeadShops { get; set; }

    public decimal? DebitMortgage { get; set; }

    public decimal? DebtBalancBegin { get; set; }

    public decimal? CreditBalancBegin { get; set; }

    public decimal? DuDk { get; set; }

    public decimal? Tmdk { get; set; }

    public decimal? Blnhdk { get; set; }

    public decimal? Chbldk { get; set; }

    public decimal? DuNo { get; set; }

    public decimal? Tmno { get; set; }

    public decimal? Blnhno { get; set; }

    public decimal? Chblno { get; set; }

    public decimal? DuTt { get; set; }

    public decimal? Tmtt { get; set; }

    public decimal? Blnhtt { get; set; }

    public decimal? Chbltt { get; set; }

    public decimal? DuCk { get; set; }

    public decimal? Tmck { get; set; }

    public decimal? Blnhck { get; set; }

    public decimal? Chblck { get; set; }

    public decimal? Chblckend { get; set; }

    public decimal? DebtArise { get; set; }

    public decimal? CreditArise { get; set; }

    public decimal? DebtBalancEnd { get; set; }

    public decimal? CreditBalancEnd { get; set; }

    public decimal? DebtAccumulated { get; set; }

    public decimal? CreditAccumulated { get; set; }

    public decimal? DebtBalancRemaining { get; set; }

    public decimal? CreditBalancRemaining { get; set; }

    public decimal? DebtBalancBeginUsd { get; set; }

    public decimal? CreditBalancBeginUsd { get; set; }

    public decimal? DebtAriseUsd { get; set; }

    public decimal? CreditAriseUsd { get; set; }

    public decimal? DebtBalancEndUsd { get; set; }

    public decimal? CreditBalancEndUsd { get; set; }

    public decimal? DebtAccumulatedUsd { get; set; }

    public decimal? CreditAccumulatedUsd { get; set; }

    public decimal? DebtBalancRemainingUsd { get; set; }

    public decimal? CreditBalancRemainingUsd { get; set; }

    public decimal? Total { get; set; }

    public string? ContractCode { get; set; }

    public string? ContractName { get; set; }

    public string? ConstructionCode { get; set; }

    public string? ConstructionName { get; set; }

    public string? ProjectCode { get; set; }

    public string? ProjectName { get; set; }

    public string? ProductionActivitieCode { get; set; }

    public string? ProductionActivitieName { get; set; }

    public string? FundingSourceCode { get; set; }

    public string? FundingSourceName { get; set; }

    public string? RevenueExpenseCode { get; set; }

    public string? RevenueExpenseName { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? DayBefore { get; set; }

    public string? NextDay { get; set; }

    public string? EndDate { get; set; }

    public string? BeginDate { get; set; }

    public string? Date { get; set; }

    public string? Note { get; set; }

    public string? Note1 { get; set; }

    public string? Note2 { get; set; }

    public string? Note3 { get; set; }

    public string? Note4 { get; set; }

    public string? Note5 { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
