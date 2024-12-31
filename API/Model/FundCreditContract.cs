using System;
using System.Collections.Generic;

namespace API.Model;

public partial class FundCreditContract
{
    public Guid Id { get; set; }

    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public int CodeUnit { get; set; }

    public string? ContractNumber { get; set; }

    public string? ContractNumberOld { get; set; }

    public string? IndentureNo { get; set; }

    public DateTime? SignDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? DateDue { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public DateTime? DisbursementDate { get; set; }

    public string? CreditProductCode { get; set; }

    public string? CreditProductName { get; set; }

    public string? PurposeCode { get; set; }

    public string? PurposeName { get; set; }

    public decimal? ContractValue { get; set; }

    public int? BorrowingTime { get; set; }

    public string? SequentialCode { get; set; }

    public string? SequentialName { get; set; }

    public decimal? AmountPaidPerMonth { get; set; }

    public string? ContractName { get; set; }

    public string? FundingSourceCode { get; set; }

    public string? FundingSourceName { get; set; }

    public string? StatusName { get; set; }

    public string? InterestPaymentMethod { get; set; }

    public string? InterePayMethCode { get; set; }

    public string? FormOfCapitalPayment { get; set; }

    public string? FormOfCapitalPaymentCode { get; set; }

    public double? InterestRateMonth { get; set; }

    public double? InterestRateYear { get; set; }

    public string? PlaceOfCapitalDistri { get; set; }

    public string? SubordinateName { get; set; }

    public bool? Disbursed { get; set; }

    public string? HouseholdType { get; set; }

    public double? OverdueInterestRate { get; set; }

    public double? OverdueInterestRateMonth { get; set; }

    public double? OverdueInterestRateYear { get; set; }

    public int? NumberOfExtensionDays { get; set; }

    public DateTime? DateDueNew { get; set; }

    public bool? Overdue { get; set; }

    public DateTime? TransferDate { get; set; }

    public string? IdDocument { get; set; }

    public string? NumberOfVoucherAcc { get; set; }

    public string? TransferBy { get; set; }

    public bool? InterestIsEqual { get; set; }

    public int? NumberOfDaysOverdue { get; set; }

    public double? InsuranceRate { get; set; }

    public double? RequiredStaffLevel { get; set; }

    public double? DirectorApprovalLevel { get; set; }

    public int? NumberOfMonthsToPayOnce { get; set; }

    public string? MethodOfCalInterest { get; set; }

    public int? NumberOfInstallmentsRest { get; set; }

    public bool Rounding { get; set; }

    public bool InterestPaymentGracePeriod { get; set; }

    public bool FixedAnnuity { get; set; }

    public bool InterestOnPrincipalBalance { get; set; }

    public double MembershipLevelRequire { get; set; }

    public int DebtFreeze { get; set; }

    public int NumberOfRenewalMonths { get; set; }

    public double RequiredLevelOfLeader { get; set; }

    public string? ContractTypeCode { get; set; }

    public string? ContractTypeName { get; set; }

    public bool AccountingDone { get; set; }

    public bool Approved { get; set; }

    public bool OddNumberLast { get; set; }

    public double? ReturnOnCapitalRate { get; set; }

    public double? ProfitRate { get; set; }

    public double? SavingRate { get; set; }

    public bool ByWeek { get; set; }

    public double? TotalSavingRate { get; set; }

    public DateTime? DateComfirm { get; set; }

    public string? SavingsBookCode { get; set; }

    public string? IdSavingsBook { get; set; }

    public DateTime? SettlementDate { get; set; }

    public int IdAsc { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public string? ModifyDate { get; set; }

    public string? Notes { get; set; }

    public string? HamletCode { get; set; }

    public string? HamletName { get; set; }

    public string? VillageCode { get; set; }

    public string? VillageName { get; set; }

    public string? WardsCode { get; set; }

    public string? WardsName { get; set; }

    public string? DistrictCode { get; set; }

    public string? DistrictName { get; set; }
}
