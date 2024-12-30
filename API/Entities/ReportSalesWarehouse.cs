using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class ReportSalesWarehouse
{
    public int Id { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public string? DataType { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? StaffCode { get; set; }

    public string? StaffName { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public double? QuantityDirectExport { get; set; }

    public double? QuantityExport { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? AmountOfMoneyBb { get; set; }

    public decimal? AmountOfMoneyBl { get; set; }

    public double? Total { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
