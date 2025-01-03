﻿using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class ReportLatePaymentTable
{
    public int Id { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? AccountSymbol { get; set; }

    public string? AccountName { get; set; }

    public int? AccountLevel { get; set; }

    public decimal? DebitBalance { get; set; }

    public decimal? DebitLetterOfGuarantee { get; set; }

    public decimal? DebitHeadShops { get; set; }

    public decimal? DebitMortgage { get; set; }

    public decimal? DebtBalancBegin { get; set; }

    public decimal? CreditBalancBegin { get; set; }

    public decimal? DebtArise { get; set; }

    public decimal? CreditArise { get; set; }

    public decimal? DebtBalancEnd { get; set; }

    public decimal? CreditBalancEnd { get; set; }

    public decimal? DebtBalancLessMonth { get; set; }

    public decimal? DebtBalancMonthTowMonth { get; set; }

    public decimal? DebtBalancTowThreeMonth { get; set; }

    public decimal? DebtBalancThreeSixMonth { get; set; }

    public decimal? DebtBalancGreaterSixMonth { get; set; }

    public decimal? TotalCreditBalanc { get; set; }

    public decimal? TotalDebtBalanc { get; set; }

    public decimal? DebtAccumulated { get; set; }

    public decimal? CreditAccumulated { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
