using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogCreditProduct
{
    public string? CreditProductCode { get; set; }

    public string? CreditProductName { get; set; }

    public int? Period { get; set; }

    public double? InterestRateYear { get; set; }

    public double? OverdueInterestRate { get; set; }

    public int? NumberOfMonthsToPayInterestOnce { get; set; }

    public int? NumberOfMonthsToPayOnce { get; set; }

    public string? FormOfCapitalPayment { get; set; }

    public string? InterestPaymentMethod { get; set; }

    public bool InterestIsEqual { get; set; }

    public bool FixedAnnuity { get; set; }

    public bool InterestOnPrincipalBalance { get; set; }

    public bool ByWeek { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public double? InterestSaveRateYear { get; set; }

    public double? InterestSaveRateMonth { get; set; }

    public double? InterestRateMonth { get; set; }
}
