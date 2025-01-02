using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class ReportArisingBalanceSheet
{
    public int Id { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public string? InOutSheet { get; set; }

    public string? AccountSymbol { get; set; }

    public string? AccountName { get; set; }

    public int? AccountLevel { get; set; }

    public decimal? DebtBalancBegin { get; set; }

    public decimal? CreditBalancBegin { get; set; }

    public decimal? DebtArise { get; set; }

    public decimal? CreditArise { get; set; }

    public decimal? DebtAccumulated { get; set; }

    public decimal? CreditAccumulated { get; set; }

    public decimal? DebtBalancEnd { get; set; }

    public decimal? CreditBalancEnd { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
