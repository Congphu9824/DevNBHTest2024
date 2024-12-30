using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class DeleteSalesSmartContentsDatum
{
    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public string? DataType { get; set; }

    public string? PumpColumnCode { get; set; }

    public string? PumpColumnName { get; set; }

    public double? NumberBegin { get; set; }

    public double? NumberEnd { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public string? UnitPackage { get; set; }

    public double? ConversionFactor { get; set; }

    public double? PackageQuantity { get; set; }

    public double? QuantityOfInventory { get; set; }

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

    public double? FeeEnvironRate { get; set; }

    public decimal? AmountFeeEnvironRate { get; set; }

    public decimal? AmountWithoutVatFee { get; set; }

    public double? PriceWithoutVatFee { get; set; }

    public string? VatType { get; set; }

    public double? VatRate { get; set; }

    public string? ProgramCode { get; set; }

    public double? DiscountRate { get; set; }

    public decimal? AmountDiscount { get; set; }

    public decimal? AmountAfterDiscount { get; set; }

    public decimal? ActualAmount { get; set; }

    public bool NotPoints { get; set; }

    public string? Season { get; set; }

    public double? CoefficientVcf { get; set; }

    public double? Temperature { get; set; }

    public double? CoefficientWcf { get; set; }

    public string? VoucherNumberContents { get; set; }

    public string? DescriptionContents { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public Guid? IdData { get; set; }

    public Guid IdSource { get; set; }

    public string? GrpName { get; set; }

    public string? GrpCode { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? NameSupplier { get; set; }

    public string? CodeSupplier { get; set; }

    public string? Loaiphieu { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? WarehoseNameReceive { get; set; }

    public double? RetailPrice { get; set; }

    public Guid? IdVouchers { get; set; }

    public Guid? IdTracing { get; set; }

    public double? Priceimp { get; set; }
}
