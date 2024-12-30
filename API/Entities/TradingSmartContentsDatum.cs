using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class TradingSmartContentsDatum
{
    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public string? DataType { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public double? Quantity15 { get; set; }

    public double? Price1 { get; set; }

    public double? DiscountRate1 { get; set; }

    public double? Price2 { get; set; }

    public double? DiscountRate2 { get; set; }

    public double? Price { get; set; }

    public double? DiscountRate { get; set; }

    public double? PriceWithoutVat { get; set; }

    public double? PriceAfterDiscount { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? AmountVat { get; set; }

    public decimal? AmountWithoutVat { get; set; }

    public double? FeeEnvironRate { get; set; }

    public decimal? AmountFeeEnvironRate { get; set; }

    public decimal? AmountWithoutVatFee { get; set; }

    public double? PriceWithoutVatFee { get; set; }

    public double? VatRate { get; set; }

    public decimal? AmountDiscount { get; set; }

    public decimal? AmountAfterDiscount { get; set; }

    public decimal? ActualAmount { get; set; }

    public double? CoefficientVcf { get; set; }

    public double? Temperature { get; set; }

    public double? CoefficientWcf { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public Guid? IdData { get; set; }

    public Guid IdSource { get; set; }

    public string? Loaiphieu { get; set; }

    public bool DataHasBeenTaken { get; set; }

    public string? TypeVat { get; set; }

    public string? VoucherNumberContents { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? AccountSymbol { get; set; }

    public double? ConversionFactor { get; set; }

    public string? UnitPackage { get; set; }

    public string? GrpCode { get; set; }

    public string? GrpName { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? CodeSupplier { get; set; }

    public string? NameSupplier { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? WarehoseNameReceive { get; set; }

    public string? ProgramCode { get; set; }

    public bool NotPoints { get; set; }

    public string? PumpColumnCode { get; set; }

    public double? Priceimp { get; set; }

    public Guid? IdTracing { get; set; }
}
