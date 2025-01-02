using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SmartUseMaterialsSave
{
    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public Guid? IdData { get; set; }

    public string? DataType { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? Description { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? Notes { get; set; }

    public Guid? IdSource { get; set; }

    public double? DiscountRate { get; set; }

    public double? Vatrate { get; set; }

    public double? AmountDiscount { get; set; }

    public double? PriceAfterDiscount { get; set; }

    public double? PriceWithoutVat { get; set; }
}
