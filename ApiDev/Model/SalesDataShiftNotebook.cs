using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SalesDataShiftNotebook
{
    public string? WarehoseData { get; set; }

    public string? DataType { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public bool Register { get; set; }

    public string? MethodOfPaymentsCode { get; set; }

    public string? MethodOfPaymentsName { get; set; }

    public string? ReasonCode { get; set; }

    public string? ReasonName { get; set; }

    public string? PumpColumnCode { get; set; }

    public string? PumpColumnName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public double? Quantity15 { get; set; }

    public double? PriceWithoutVat { get; set; }

    public decimal? AmountWithoutVat { get; set; }

    public decimal? AmountVat { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public double? VatRate { get; set; }

    public double? DiscountRate { get; set; }

    public decimal? AmountDiscount { get; set; }

    public decimal? AmountAfterDiscount { get; set; }
}
