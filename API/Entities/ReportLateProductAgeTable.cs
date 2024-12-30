using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class ReportLateProductAgeTable
{
    public int Id { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? CodeSupplier { get; set; }

    public string? NameSupplier { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Price { get; set; }

    public double? QuantityEnd { get; set; }

    public decimal? AmountOfMoneyEnd { get; set; }

    public double? QuantityThree { get; set; }

    public decimal? AmountOfMoneyThree { get; set; }

    public double? QuantitySix { get; set; }

    public decimal? AmountOfMoneySix { get; set; }

    public double? QuantityNine { get; set; }

    public decimal? AmountOfMoneyNine { get; set; }

    public double? QuantityYear { get; set; }

    public decimal? AmountOfMoneyYear { get; set; }

    public double? QuantityOverYear { get; set; }

    public decimal? AmountOfMoneyOverYear { get; set; }

    public decimal? AccumulatedImp { get; set; }

    public decimal? AccumulatedExp { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
