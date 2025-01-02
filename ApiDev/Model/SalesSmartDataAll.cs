using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SalesSmartDataAll
{
    public int IdAsc { get; set; }

    public Guid IdContents { get; set; }

    public string? DataType { get; set; }

    public Guid Id { get; set; }

    public string? DataName { get; set; }

    public string? WarehoseData { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? PersonCode { get; set; }

    public string? PersonName { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public string? InvoiceTemplate { get; set; }

    public string? InvoiceSymbol { get; set; }

    public string? LicensePlates { get; set; }

    public string? VoucherStatus { get; set; }

    public bool Register { get; set; }

    public bool Einvoice { get; set; }

    public string? Notes { get; set; }

    public string? Description { get; set; }

    public string? MethodOfPaymentsName { get; set; }

    public string? MethodOfPaymentsCode { get; set; }

    public string? ReasonName { get; set; }

    public string? ReasonCode { get; set; }

    public string? ObjectTaxCode { get; set; }

    public string? ObjectAddress { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectCode { get; set; }

    public string? PersonTaxCode { get; set; }

    public string? PersonAddress { get; set; }

    public string? PumpColumnCode { get; set; }

    public string? PumpColumnName { get; set; }

    public double? NumberBegin { get; set; }

    public double? NumberEnd { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? QuantityConsignmentGoods { get; set; }

    public double? QuantityTest { get; set; }

    public double? QuantityInternal { get; set; }

    public double? QuantityContract { get; set; }

    public double? QuantityRetail { get; set; }

    public double? Quantity { get; set; }

    public double? Quantity15 { get; set; }

    public double? Price { get; set; }

    public double? PriceWithoutVat { get; set; }

    public double? PriceAfterDiscount { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? AmountVat { get; set; }

    public decimal? AmountWithoutVat { get; set; }

    public double? VatRate { get; set; }

    public decimal? AmountDiscount { get; set; }

    public decimal? AmountAfterDiscount { get; set; }

    public double? FeeEnvironRate { get; set; }

    public decimal? AmountFeeEnvironRate { get; set; }

    public double? CoefficientVcf { get; set; }

    public double? Temperature { get; set; }

    public double? CoefficientWcf { get; set; }

    public string? DescriptionContents { get; set; }

    public double? DiscountRate { get; set; }

    public string? Season { get; set; }

    public string? SalesChannelCode { get; set; }

    public string? SalesChannelName { get; set; }

    public string? StaffCode { get; set; }

    public string? StaffName { get; set; }

    public decimal? AmountPayment { get; set; }

    public decimal? MoneyGuests { get; set; }

    public decimal? MoneyReturnGuests { get; set; }

    public bool NotAccumulatePoints { get; set; }

    public bool NotPoints { get; set; }

    public bool Vat { get; set; }

    public string? AccountingType { get; set; }

    public decimal? MoneyDiscountOnBill { get; set; }

    public decimal? AmountDiscountOnBill { get; set; }

    public decimal? TotalAmountWithoutVat { get; set; }

    public decimal? TotalAmountVat { get; set; }

    public decimal? AmountVoucher { get; set; }

    public string? VoucherNumber { get; set; }

    public decimal? HeadAmountDiscount { get; set; }

    public decimal? AmountTotal { get; set; }

    public decimal? SubAmountPoints { get; set; }

    public int? AccumulatePoints { get; set; }

    public decimal? PointsMoney { get; set; }

    public DateTime? BirthDate { get; set; }

    public bool SaveTemp { get; set; }

    public string? GroupName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupAreaName { get; set; }

    public string? GroupAreaCode { get; set; }

    public DateTime? InvDate { get; set; }

    public string? ObjectEmail { get; set; }

    public bool NotEnvironment { get; set; }

    public bool? InvoiceCancel { get; set; }

    public Guid? IdDocumment { get; set; }

    public bool IsAccouting { get; set; }

    public decimal? DebtBalanc { get; set; }

    public decimal? DebitBalance { get; set; }

    public bool InvocePublished { get; set; }

    public string? KeyInvoce { get; set; }

    public string? EnumberInvoice { get; set; }

    public string? EnumberInvoiceDraft { get; set; }

    public string? InvoiceResult { get; set; }

    public string? LevelDiscount { get; set; }

    public bool CollectMoneyReturnGuests { get; set; }

    public string? VatType { get; set; }

    public Guid? IdData { get; set; }

    public string? CodeSupplier { get; set; }

    public string? NameSupplier { get; set; }

    public string? TypeName { get; set; }

    public string? TypeCode { get; set; }

    public string? GrpName { get; set; }

    public string? GrpCode { get; set; }

    public double? PriceWithoutVatFee { get; set; }

    public decimal? AmountWithoutVatFee { get; set; }

    public string? ProgramCode { get; set; }

    public decimal? ActualAmount { get; set; }

    public string? Location { get; set; }

    public string? VoucherNumberContents { get; set; }

    public double? RetailPrice { get; set; }

    public string? WarehoseNameReceive { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? WarehoseName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? Expr1 { get; set; }

    public string? ContractCode { get; set; }

    public string? ContractName { get; set; }

    public string? ProjectCode { get; set; }

    public string? ProjectName { get; set; }

    public string? NumberOfVouchersDoc { get; set; }

    public string? MemberRate { get; set; }

    public double? NumberFuel { get; set; }

    public double? NumberInvPublish { get; set; }

    public string? BatchWarehose { get; set; }
}
