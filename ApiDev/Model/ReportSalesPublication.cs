using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class ReportSalesPublication
{
    public int Id { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public string? DataType { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? VoucherDate { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? QuantityOilPub { get; set; }

    public double? QuantityLubPub { get; set; }

    public double? QuantityLub { get; set; }

    public double? QuantityE5a92 { get; set; }

    public double? QuantityE5a95 { get; set; }

    public double? QuantityDo { get; set; }

    public double? Total { get; set; }

    public double? SalesSgcin { get; set; }

    public double? SalesSgcon { get; set; }

    public double? StockRatio { get; set; }

    public double? SalesPeriod { get; set; }

    public double? Uneven { get; set; }

    public double? Growth { get; set; }

    public double? Percentage { get; set; }

    public string? TimePeriod { get; set; }

    public string? Note { get; set; }

    public string? NoteYear { get; set; }

    public string? NoteMonth { get; set; }

    public string? NoteTime { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
