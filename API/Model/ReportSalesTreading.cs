using System;
using System.Collections.Generic;

namespace API.Model;

public partial class ReportSalesTreading
{
    public int Id { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public string? DataName { get; set; }

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

    public string? ReasonCode { get; set; }

    public string? ReasonName { get; set; }

    public string? MethodOfPaymentsCode { get; set; }

    public string? MethodOfPaymentsName { get; set; }

    public bool? Pricing { get; set; }

    public bool? Einvoice { get; set; }

    public string? VoucherStatus { get; set; }

    public string? LicensePlates { get; set; }

    public string? InvoiceSymbol { get; set; }

    public string? InvoiceTemplate { get; set; }

    public bool? Register { get; set; }

    public string? DataType { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? AccountSymbol { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? WarehoseNameReceive { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? UnitPcs { get; set; }

    public string? UnitPackage { get; set; }

    public double? Quantity { get; set; }

    public double? QuantityEnd { get; set; }

    public double? Price { get; set; }

    public double? Price15 { get; set; }

    public double? PriceEnd { get; set; }

    public double? PriceWithoutVat { get; set; }

    public double? PriceAfterDiscount { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? AmountOfMoney15 { get; set; }

    public decimal? AmountOfMoneyEnd { get; set; }

    public string? ForeignCurrencyType { get; set; }

    public double? ExchangeRate { get; set; }

    public double? AmountOfMoneyUsd { get; set; }

    public string? VatType { get; set; }

    public double? VatRate { get; set; }

    public decimal? AmountVat { get; set; }

    public decimal? AmountWithoutVat { get; set; }

    public double? DiscountRate { get; set; }

    public double? DiscountRate1 { get; set; }

    public double? DiscountRate2 { get; set; }

    public double? DiscountRate3 { get; set; }

    public double? DiscountRate4 { get; set; }

    public double? DiscountRate5 { get; set; }

    public double? DiscountRate6 { get; set; }

    public double? DiscountRate7 { get; set; }

    public double? DiscountRate8 { get; set; }

    public double? DiscountRate9 { get; set; }

    public double? DiscountRate10 { get; set; }

    public double? DiscountRate11 { get; set; }

    public double? DiscountRate12 { get; set; }

    public double? DiscountRate13 { get; set; }

    public double? DiscountRate14 { get; set; }

    public double? DiscountRate15 { get; set; }

    public double? DiscountRate16 { get; set; }

    public double? DiscountRate17 { get; set; }

    public double? DiscountRate18 { get; set; }

    public double? DiscountRate19 { get; set; }

    public double? DiscountRate20 { get; set; }

    public double? DiscountRate21 { get; set; }

    public double? DiscountRate22 { get; set; }

    public double? DiscountRate23 { get; set; }

    public double? DiscountRate24 { get; set; }

    public double? DiscountRate25 { get; set; }

    public double? DiscountRate26 { get; set; }

    public double? DiscountRate27 { get; set; }

    public double? DiscountRate28 { get; set; }

    public double? DiscountRate29 { get; set; }

    public double? DiscountRate30 { get; set; }

    public double? DiscountRate31 { get; set; }

    public double? Quantity1 { get; set; }

    public double? Quantity2 { get; set; }

    public double? Quantity3 { get; set; }

    public double? Quantity4 { get; set; }

    public double? Quantity5 { get; set; }

    public double? Quantity6 { get; set; }

    public double? Quantity7 { get; set; }

    public double? Quantity8 { get; set; }

    public double? Quantity9 { get; set; }

    public double? Quantity10 { get; set; }

    public double? Quantity11 { get; set; }

    public double? Quantity12 { get; set; }

    public double? Quantity13 { get; set; }

    public double? Quantity14 { get; set; }

    public double? Quantity15 { get; set; }

    public double? Quantity16 { get; set; }

    public double? Quantity17 { get; set; }

    public double? Quantity18 { get; set; }

    public double? Quantity19 { get; set; }

    public double? Quantity20 { get; set; }

    public double? Quantity21 { get; set; }

    public double? Quantity22 { get; set; }

    public double? Quantity23 { get; set; }

    public double? Quantity24 { get; set; }

    public double? Quantity25 { get; set; }

    public double? Quantity26 { get; set; }

    public double? Quantity27 { get; set; }

    public double? Quantity28 { get; set; }

    public double? Quantity29 { get; set; }

    public double? Quantity30 { get; set; }

    public double? Quantity31 { get; set; }

    public double? CoefficientVcf { get; set; }

    public double? Temperature { get; set; }

    public double? CoefficientWcf { get; set; }

    public double? FeeEnvironRate { get; set; }

    public decimal? AmountFeeEnvironRate { get; set; }

    public decimal? AmountWithoutVatFee { get; set; }

    public double? PriceWithoutVatFee { get; set; }

    public decimal? AmountDiscount { get; set; }

    public decimal? AmountAfterDiscount { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public string? DayBefore { get; set; }

    public string? NextDay { get; set; }

    public string? EndDate { get; set; }

    public string? BeginDate { get; set; }

    public string? Date { get; set; }

    public string? IdData { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
