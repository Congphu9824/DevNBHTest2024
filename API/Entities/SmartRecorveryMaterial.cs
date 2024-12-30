using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SmartRecorveryMaterial
{
    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public string? DataType { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? StageCode { get; set; }

    public string? StageName { get; set; }

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

    public double? Weight { get; set; }

    public double? QuantityNotGood { get; set; }

    public double? WeightNotGood { get; set; }

    public double? Price { get; set; }

    public double? PriceAfterDiscount { get; set; }

    public double? PriceWithoutVat { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? AmountVat { get; set; }

    public decimal? AmountWithoutVat { get; set; }

    public double? VatRate { get; set; }

    public double? DiscountRate { get; set; }

    public decimal? AmountDiscount { get; set; }

    public decimal? AmountAfterDiscount { get; set; }

    public string? ProjectCode { get; set; }

    public string? ProjectName { get; set; }

    public string? VoucherNumberContents { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public Guid? IdData { get; set; }

    public Guid? IdSource { get; set; }

    public Guid? IdVouchers { get; set; }

    public Guid? IdTracing { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? Description { get; set; }
}
