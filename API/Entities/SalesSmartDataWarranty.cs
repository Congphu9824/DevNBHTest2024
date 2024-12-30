using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SalesSmartDataWarranty
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

    public string? Notes { get; set; }

    public string? Description { get; set; }

    public string? MethodOfPaymentsName { get; set; }

    public string? MethodOfPaymentsCode { get; set; }

    public string? ReasonName { get; set; }

    public string? ReasonCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? ObjectTaxCode { get; set; }

    public string? ObjectAddress { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectCode { get; set; }

    public string? PersonTaxCode { get; set; }

    public string? PersonAddress { get; set; }

    public string? PumpColumnCode { get; set; }

    public string? PumpColumnName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

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

    public string? VoucherNumber { get; set; }

    public decimal? Expr1 { get; set; }

    public decimal? AmountTotal { get; set; }

    public decimal? SubAmountPoints { get; set; }

    public int? AccumulatePoints { get; set; }

    public decimal? PointsMoney { get; set; }

    public DateTime? BirthDate { get; set; }

    public bool SaveTemp { get; set; }

    public bool? InvoiceCancel { get; set; }

    public Guid? IdDocumment { get; set; }

    public string? VatType { get; set; }

    public string? Expr2 { get; set; }

    public string? Expr3 { get; set; }

    public string? WarehoseNameReceive { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public Guid? IdData { get; set; }

    public string? VoucherNumberContents { get; set; }
}
