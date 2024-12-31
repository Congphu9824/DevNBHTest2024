using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SmartContentsDatum
{
    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public string? DataType { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? AccountSymbol { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? WarehoseNameReceive { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? UnitPcs { get; set; }

    public string? UnitPackage { get; set; }

    public double? ConversionFactor { get; set; }

    public double? PackageQuantity { get; set; }

    public double? QuantityOfInventory { get; set; }

    public double? Quantity { get; set; }

    public double? Quantity15 { get; set; }

    public double? RetailPrice { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? AmountVat { get; set; }

    public decimal? AmountWithoutVat { get; set; }

    public string? ForeignCurrencyType { get; set; }

    public double? ExchangeRate { get; set; }

    public double? AmountOfMoneyUsd { get; set; }

    public string? VatType { get; set; }

    public double? VatRate { get; set; }

    public double? DiscountRate { get; set; }

    public decimal? AmountDiscount { get; set; }

    public decimal? AmountAfterDiscount { get; set; }

    public double? FeeEnvironRate { get; set; }

    public decimal? AmountFeeEnvironRate { get; set; }

    public double? CostPrice { get; set; }

    public decimal? CostOfGoodsSold { get; set; }

    public string? DebitObjectCode { get; set; }

    public string? DebitObjectName { get; set; }

    public string? DebitObjectTax { get; set; }

    public string? CreditObjectCode { get; set; }

    public string? CreditObjectName { get; set; }

    public string? CreditObjectTax { get; set; }

    public string? InvoiceNumberContents { get; set; }

    public string? Description { get; set; }

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

    public string? DebitSideOut { get; set; }

    public string? CreditSideOut { get; set; }

    public double? CoefficientVcf { get; set; }

    public double? Temperature { get; set; }

    public double? CoefficientWcf { get; set; }

    public string? VoucherNumberContents { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public Guid? IdData { get; set; }

    public Guid IdSource { get; set; }

    public string? SignTransfer { get; set; }

    public decimal? AmountOfMoney15 { get; set; }

    public decimal? CostOfGoodsSold15 { get; set; }

    public string? Season { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? AmountExciseTax { get; set; }

    public string? ExciseTaxRate { get; set; }

    public double? PriceEnd { get; set; }

    public double? BogRate { get; set; }

    public double? AmountBog { get; set; }

    public double? AmountTotal { get; set; }

    public bool EnviromentByKg { get; set; }

    public string? ShipmentNumber { get; set; }

    public string? GrpName { get; set; }

    public string? GrpCode { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? NameSupplier { get; set; }

    public string? CodeSupplier { get; set; }

    public string? Loaiphieu { get; set; }

    public Guid? IdVouchers { get; set; }

    public Guid IdTracing { get; set; }

    public DateTime? DateShipment { get; set; }

    public int? AmountImp { get; set; }

    public string? WarehoseData { get; set; }

    public double? ImpTaxRate { get; set; }

    public decimal? AmountImpTax { get; set; }

    public string? KeyWord { get; set; }
}
