using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SmartContentsDebtRepaymentPlan
{
    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public string? DataType { get; set; }

    public int? CodeUnit { get; set; }

    public string? FundingSourceCode { get; set; }

    public string? FundingSourceName { get; set; }

    public DateTime? FirstDateOfPayment { get; set; }

    public DateTime? DateOfPayment { get; set; }

    public int? NumberOfDays { get; set; }

    public int? PaymentPeriod { get; set; }

    public decimal? OriginalBalance { get; set; }

    public decimal? PrincipalAmount { get; set; }

    public decimal? AmountOfInterest { get; set; }

    public decimal? TotalInterestPrincipal { get; set; }

    public decimal? AmountOfSavings { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Notes { get; set; }
}
