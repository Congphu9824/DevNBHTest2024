using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class ReportDeliveryNotYetDelivered
{
    public int Id { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public bool? Finish { get; set; }

    public Guid? IdVoucher { get; set; }

    public string? NumberOfVouchers { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? VoucherDate { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? CodeSupplier { get; set; }

    public string? NameSupplier { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? PriceOrder { get; set; }

    public double? QuantityOrder { get; set; }

    public decimal? AmountOfMoneyOrder { get; set; }

    public double? PriceDelivered { get; set; }

    public double? QuantityDelivered { get; set; }

    public decimal? AmountOfMoneyDelivered { get; set; }

    public double? PriceEnd { get; set; }

    public double? QuantityEnd { get; set; }

    public decimal? AmountOfMoneyEnd { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
