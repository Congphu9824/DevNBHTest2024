using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SalesSmartDatum
{
    public Guid Id { get; set; }

    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public string? WarehoseData { get; set; }

    public decimal? AmountTransferred { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? PersonCode { get; set; }

    public string? PersonName { get; set; }

    public string? PersonAddress { get; set; }

    public string? PersonTaxCode { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectAddress { get; set; }

    public string? ObjectTaxCode { get; set; }

    public double? DiscountRate { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? WarehoseNameReceive { get; set; }

    public string? ReasonCode { get; set; }

    public string? ReasonName { get; set; }

    public string? MethodOfPaymentsCode { get; set; }

    public string? MethodOfPaymentsName { get; set; }

    public string? ShippingMethodsCode { get; set; }

    public string? ShippingMethodsName { get; set; }

    public string? Description { get; set; }

    public string? Notes { get; set; }

    public bool Einvoice { get; set; }

    public bool InvocePublished { get; set; }

    public string? KeyInvoce { get; set; }

    public string? EnumberInvoice { get; set; }

    public string? EnumberInvoiceDraft { get; set; }

    public string? InvoiceResult { get; set; }

    public string? VoucherStatus { get; set; }

    public string? LicensePlates { get; set; }

    public string? InvoiceSymbol { get; set; }

    public string? InvoiceTemplate { get; set; }

    public string? SalesChannelCode { get; set; }

    public string? SalesChannelName { get; set; }

    public string? StaffCode { get; set; }

    public string? StaffName { get; set; }

    public Guid? IdDocumment { get; set; }

    public bool Register { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public bool? InvoiceCancel { get; set; }

    public string? ObjectEmail { get; set; }

    public bool NotEnvironment { get; set; }

    public DateTime? InvDate { get; set; }

    public string? GroupAreaCode { get; set; }

    public string? GroupAreaName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public bool SaveTemp { get; set; }

    public DateTime? BirthDate { get; set; }

    public decimal? PointsMoney { get; set; }

    public int? AccumulatePoints { get; set; }

    public decimal? SubAmountPoints { get; set; }

    public decimal? AmountTotal { get; set; }

    public decimal? AmountDiscount { get; set; }

    public string? VoucherNumber { get; set; }

    public decimal? AmountVoucher { get; set; }

    public decimal? AmountPayment { get; set; }

    public decimal? MoneyGuests { get; set; }

    public decimal? MoneyReturnGuests { get; set; }

    public decimal? TotalAmountVat { get; set; }

    public decimal? TotalAmountWithoutVat { get; set; }

    public decimal? AmountDiscountOnBill { get; set; }

    public decimal? MoneyDiscountOnBill { get; set; }

    public bool NotAccumulatePoints { get; set; }

    public string? ProgramCode { get; set; }

    public string? Location { get; set; }

    public bool Vat { get; set; }

    public string? Loaiphieu { get; set; }

    public string? AccountingType { get; set; }

    public bool IsAccouting { get; set; }

    public decimal? DebtBalanc { get; set; }

    public decimal? DebitBalance { get; set; }

    public string? LevelDiscount { get; set; }

    public bool CollectMoneyReturnGuests { get; set; }

    public double? DiscountRateHead { get; set; }

    public bool Finish { get; set; }

    public Guid? IdInheritSales { get; set; }

    public bool IsInherited { get; set; }

    public decimal? AccumulatedPoints { get; set; }

    public string? NumberOfVouchersDoc { get; set; }

    public string? ContractCode { get; set; }

    public string? ContractName { get; set; }

    public string? ProjectCode { get; set; }

    public string? ProjectName { get; set; }

    public int? SmartSoftId { get; set; }

    public string? MemberRate { get; set; }

    public string? NumberOfVoucherInherit { get; set; }

    public bool ComfirmVoucher { get; set; }

    public DateTime? DateDraf { get; set; }

    public string? InvStatus { get; set; }

    public string? TaxAuthorityCode { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? ShiftCode { get; set; }

    public string? ShiftName { get; set; }

    public bool ExpPrivate { get; set; }
}
