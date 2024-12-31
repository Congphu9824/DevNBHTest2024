using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SalarySchedule
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    /// <summary>
    /// Loại bảng lương
    /// </summary>
    public string? DataType { get; set; }

    /// <summary>
    /// Mã loại bảng lương
    /// </summary>
    public string? CodeSalaryType { get; set; }

    /// <summary>
    /// Tên loại bảng lương
    /// </summary>
    public string? NameSalaryType { get; set; }

    /// <summary>
    /// Mã nhân viên
    /// </summary>
    public string? ObjectCode { get; set; }

    /// <summary>
    /// Tên nhân viên
    /// </summary>
    public string? ObjectName { get; set; }

    public DateTime? RecordDate { get; set; }

    /// <summary>
    /// Tháng lương
    /// </summary>
    public string? MonthText { get; set; }

    /// <summary>
    /// Hệ số lương
    /// </summary>
    public double? SalaryCoefficient { get; set; }

    /// <summary>
    /// Lương cơ bản
    /// </summary>
    public decimal? SalaryBasic { get; set; }

    /// <summary>
    /// Thực nhận
    /// </summary>
    public decimal? ActuallyReceived { get; set; }

    /// <summary>
    /// Mã phòng
    /// </summary>
    public string? RoomCode { get; set; }

    /// <summary>
    /// Tên phòng
    /// </summary>
    public string? RoomName { get; set; }

    /// <summary>
    /// Số tài khoản ngân hàng
    /// </summary>
    public string? BankNumber { get; set; }

    /// <summary>
    /// Tên ngân hàng
    /// </summary>
    public string? BankName { get; set; }

    /// <summary>
    /// Tên tài khoản ngân hàng
    /// </summary>
    public string? AccountName { get; set; }

    /// <summary>
    /// Chức danh, chức vụ
    /// </summary>
    public string? Position { get; set; }

    /// <summary>
    /// Mã số thu nhập
    /// </summary>
    public string? IncomeCode { get; set; }

    /// <summary>
    /// Mã đơn vị trực thuộc
    /// </summary>
    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    /// <summary>
    /// Số ngày công
    /// </summary>
    public double? NumberOfWorkdays { get; set; }

    /// <summary>
    /// Số ngày làm việc
    /// </summary>
    public double? NumberOfDaysWorked { get; set; }

    /// <summary>
    /// Tỷ lệ bảo hiểm
    /// </summary>
    public double? RateInsurance { get; set; }

    /// <summary>
    /// Tỷ lệ bảo hiểm XH
    /// </summary>
    public double? RateSocialInsurance { get; set; }

    /// <summary>
    /// Tỷ lệ bảo hiểm y tế
    /// </summary>
    public double? RateHealthInsurance { get; set; }

    /// <summary>
    /// Tỷ lệ BH thất nghiệp
    /// </summary>
    public double? RateUnemploymentInsurance { get; set; }

    /// <summary>
    /// Ghi chú
    /// </summary>
    public string? Notes { get; set; }

    public decimal? AllowanceTelephone { get; set; }

    public decimal? AllowanceCostume { get; set; }

    public decimal? AllowanceMeals { get; set; }

    public decimal? AllowanceGasoline { get; set; }

    public decimal? RewardComplyWith { get; set; }

    public decimal? RewardOvertime { get; set; }

    public decimal? RewardOther { get; set; }

    public decimal? TotalMoney { get; set; }

    public decimal? Salary { get; set; }

    public decimal? SalaryTaxes { get; set; }

    public decimal? SalaryAdvance { get; set; }

    public decimal? ExceptInsurance { get; set; }

    public decimal? TotalDeduction { get; set; }

    public decimal? NonTaxableIncome { get; set; }

    public decimal? TaxableIncome { get; set; }

    public decimal? AllowancesFamily { get; set; }

    public decimal? IncomeTaxable { get; set; }

    public decimal? PersonalIncomeTaxable { get; set; }

    public decimal? NumberOfDependents { get; set; }

    public decimal? AllowanceAwayHome { get; set; }

    public decimal? AllowanceMealsTax { get; set; }

    public decimal? TotalMeals { get; set; }

    public decimal? RewardsTrain { get; set; }

    public decimal? AttendanceBonus { get; set; }

    public int? ReduceYourSelf { get; set; }

    public int? DependentDeduction { get; set; }

    public double? SalaryRate { get; set; }

    public double? OvertimeHours150 { get; set; }

    public double? OvertimeHours200 { get; set; }

    public double? OvertimeHours300 { get; set; }

    public double? OvertimeHours { get; set; }

    public int? OvertimeSalaryNoTax { get; set; }

    public int? OvertimeSalaryTax { get; set; }

    public int? RewardOvertimeTax { get; set; }

    public int? AllowanceOther { get; set; }

    public int? UnionFees { get; set; }

    public double? RateSocialInsuranceCompany { get; set; }

    public double? RateHealthInsuranceCompany { get; set; }

    public double? RateUnemploymentInsuranceCompany { get; set; }

    public double? RateInsuranceCompany { get; set; }

    public int? ExceptInsuranceCompany { get; set; }

    public int? UnionFeesCompany { get; set; }

    public int? BirthdayBonus { get; set; }

    public int? HolidaysBonus { get; set; }

    public int? WeddingSupport { get; set; }

    public int? AccidentSupport { get; set; }

    public int? UnemploymentInsurance { get; set; }

    public int? UnemploymentInsuranceCompany { get; set; }

    public int? SocialInsurance { get; set; }

    public int? SocialInsuranceCompany { get; set; }

    public int? HealthInsurance { get; set; }

    public int? HealthInsuranceCompany { get; set; }

    public Guid? Iddata { get; set; }

    public bool Accounted { get; set; }
}
