using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class DataExportManu
{
    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? QuantityOfInventory { get; set; }

    public double? Quantity15 { get; set; }

    public double? Quantity { get; set; }

    public double? Weight { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public double? PriceWithoutVat { get; set; }

    public double? PriceAfterDiscount { get; set; }

    public decimal? AmountVat { get; set; }

    public decimal? AmountWithoutVat { get; set; }

    public double? VatRate { get; set; }

    public double? DiscountRate { get; set; }

    public decimal? AmountDiscount { get; set; }

    public decimal? AmountAfterDiscount { get; set; }

    public string? VoucherNumberContents { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public Guid? IdData { get; set; }

    public Guid IdSource { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? WarehoseNameReceive { get; set; }

    public Guid? IdVouchers { get; set; }

    public Guid? IdTracing { get; set; }

    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public string? DataType { get; set; }

    public int IsPromotion { get; set; }

    public string? BatchWarehose { get; set; }

    public double? NumberFuel { get; set; }

    public double? NumberInvPublish { get; set; }
}
