﻿using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SmartDataYesVat
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

    public string? ReasonCode { get; set; }

    public string? ReasonName { get; set; }

    public string? MethodOfPaymentsCode { get; set; }

    public string? MethodOfPaymentsName { get; set; }

    public string? Description { get; set; }

    public string? Notes { get; set; }

    public bool Pricing { get; set; }

    public bool Einvoice { get; set; }

    public string? VoucherStatus { get; set; }

    public string? LicensePlates { get; set; }

    public string? InvoiceSymbol { get; set; }

    public string? InvoiceTemplate { get; set; }

    public bool Register { get; set; }

    public int IdAsc { get; set; }

    public string? DataTypeContents { get; set; }

    public Guid IdContents { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? AccountSymbol { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? WarehoseNameReceive { get; set; }

    public string? ProductName { get; set; }

    public string? ProductCode { get; set; }

    public string? UnitPcs { get; set; }

    public string? UnitPackage { get; set; }

    public double? ConversionFactor { get; set; }

    public double? QuantityOfInventory { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public string? ForeignCurrencyType { get; set; }

    public double? ExchangeRate { get; set; }

    public double? AmountOfMoneyUsd { get; set; }

    public string? VatType { get; set; }

    public double? VatRate { get; set; }

    public decimal? AmountVat { get; set; }

    public double? DiscountRate { get; set; }

    public decimal? AmountDiscount { get; set; }

    public double? FeeEnvironRate { get; set; }

    public decimal? AmountFeeEnvironRate { get; set; }

    public string? DebitObjectCode { get; set; }

    public string? DebitObjectName { get; set; }

    public string? DebitObjectTax { get; set; }

    public string? CreditObjectCode { get; set; }

    public string? CreditObjectName { get; set; }

    public string? CreditObjectTax { get; set; }

    public string? DescriptionContents { get; set; }

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

    public int? CodeUnitContents { get; set; }

    public bool IsActiveContents { get; set; }

    public Guid? IdData { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public bool? Selectted { get; set; }

    public bool? CostAllotment { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public string? InvoiceNumberContents { get; set; }

    public decimal? CostOfGoodsSold { get; set; }

    public decimal? CostOfGoodsSold15 { get; set; }

    public double? CostPrice { get; set; }

    public decimal? AmountAfterDiscount { get; set; }

    public decimal? AmountWithoutVat { get; set; }

    public double? PackageQuantity { get; set; }

    public string? DebitSideOut { get; set; }

    public string? CreditSideOut { get; set; }

    public double? CoefficientVcf { get; set; }

    public double? Temperature { get; set; }

    public double? CoefficientWcf { get; set; }

    public string? VoucherNumberContents { get; set; }

    public Guid IdSource { get; set; }

    public double? Quantity15 { get; set; }

    public string? SignTransfer { get; set; }

    public bool? ComfirmVoucher { get; set; }

    public string? VoucherNoInherit { get; set; }

    public string? IdDataHead { get; set; }

    public bool? InvoiceCancel { get; set; }

    public string? GroupAreaCode { get; set; }

    public string? GroupAreaName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public bool Vat { get; set; }
}
