using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SmartDataVoucher
{
    public Guid Id { get; set; }

    public bool Delivered { get; set; }

    public string? DataType { get; set; }

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

    public string? Description { get; set; }

    public string? Notes { get; set; }

    public bool Pricing { get; set; }

    public bool Einvoice { get; set; }

    public string? VoucherStatus { get; set; }

    public string? InvoiceSymbol { get; set; }

    public string? InvoiceTemplate { get; set; }

    public bool Register { get; set; }

    public int IdAsc { get; set; }

    public Guid IdContents { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? AccountSymbol { get; set; }

    public string? ForeignCurrencyType { get; set; }

    public double? ExchangeRate { get; set; }

    public double? AmountOfMoneyUsd { get; set; }

    public double? FeeEnvironRate { get; set; }

    public decimal? AmountFeeEnvironRate { get; set; }

    public string? DebitObjectCode { get; set; }

    public string? DebitObjectName { get; set; }

    public string? DebitObjectTax { get; set; }

    public string? CreditObjectCode { get; set; }

    public string? CreditObjectName { get; set; }

    public string? CreditObjectTax { get; set; }

    public string? DescriptionContents { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? RevenueExpenseCode { get; set; }

    public string? RevenueExpenseName { get; set; }

    public string? ContractCode { get; set; }

    public string? ContractName { get; set; }

    public string? ConstructionCode { get; set; }

    public string? ConstructionName { get; set; }

    public string? ProjectCode { get; set; }

    public string? ProjectName { get; set; }

    public string? RoomCode { get; set; }

    public string? RoomName { get; set; }

    public string? ProductionActivitieCode { get; set; }

    public string? ProductionActivitieName { get; set; }

    public string? FundingSourceCode { get; set; }

    public string? FundingSourceName { get; set; }

    public string? NotesContents { get; set; }

    public int IdAscContents { get; set; }

    public Guid? IdData { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public bool? Selectted { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public string? InvoiceNumberContents { get; set; }

    public string? DebitSideOut { get; set; }

    public string? CreditSideOut { get; set; }

    public double? CoefficientVcf { get; set; }

    public double? Temperature { get; set; }

    public double? CoefficientWcf { get; set; }

    public string? VoucherNumberContents { get; set; }

    public Guid IdSource { get; set; }

    public double? Quantity { get; set; }
}
