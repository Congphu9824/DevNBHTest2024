using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SmartDataIndenture
{
    public Guid Id { get; set; }

    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public int CodeUnit { get; set; }

    public string? ContractNumber { get; set; }

    public string? ContractName { get; set; }

    public Guid? IdContract { get; set; }

    public string? IndentureNo { get; set; }

    public DateTime? SignDate { get; set; }

    public DateTime? DisbursementDate { get; set; }

    public DateTime? DateDue { get; set; }

    public DateTime? EndDate { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectAddress { get; set; }

    public string? CreditProductCode { get; set; }

    public string? CreditProductName { get; set; }

    public string? PurposeCode { get; set; }

    public string? PurposeName { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? ContractValue { get; set; }

    public int? BorrowingTime { get; set; }

    public decimal? AmountPaidPerMonth { get; set; }

    public string? InterestPaymentMethod { get; set; }

    public string? InterePayMethCode { get; set; }

    public string? FormOfCapitalPayment { get; set; }

    public string? FormOfCapitalPaymentCode { get; set; }

    public double? InterestRateYear { get; set; }

    public bool? Disbursed { get; set; }

    public double? OverdueInterestRate { get; set; }

    public string? IdDocument { get; set; }

    public string? NumberOfVoucherAcc { get; set; }

    public bool? InterestIsEqual { get; set; }

    public int? NumberOfMonthsToPayOnce { get; set; }

    public int? NumberOfMonthsToPayInterestOnce { get; set; }

    public string? MethodOfCalInterest { get; set; }

    public int? NumberOfInstallmentsRest { get; set; }

    public bool Rounding { get; set; }

    public bool InterestPaymentGracePeriod { get; set; }

    public bool FixedAnnuity { get; set; }

    public bool InterestOnPrincipalBalance { get; set; }

    public string? ContractTypeCode { get; set; }

    public string? ContractTypeName { get; set; }

    public int IdAsc { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public string? ModifyDate { get; set; }

    public string? Notes { get; set; }

    public string? Description { get; set; }
}
