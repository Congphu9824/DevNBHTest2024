using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class ReportSalesWarehouseStageLoss
{
    public int Id { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public string? DataType { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

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

    public double? Total { get; set; }

    public string? Description { get; set; }

    public string? Note { get; set; }

    public double? PriceBegin { get; set; }

    public double? QuantityBegin { get; set; }

    public decimal? AmountOfMoneyBegin { get; set; }

    public double? QuantityBegin15 { get; set; }

    public double? PriceImp { get; set; }

    public double? QuantityImp { get; set; }

    public double? QuantityImp15 { get; set; }

    public decimal? AmountOfMoneyImp { get; set; }

    public double? PriceExp { get; set; }

    public double? QuantityExp { get; set; }

    public double? QuantityExp15 { get; set; }

    public decimal? AmountOfMoneyExp { get; set; }

    public double? PriceAttrition { get; set; }

    public double? QuantityAttrition { get; set; }

    public double? QuantityAttrition15 { get; set; }

    public decimal? AmountOfMoneyAttrition { get; set; }

    public double? PriceEnd { get; set; }

    public double? QuantityEnd { get; set; }

    public double? QuantityEnd15 { get; set; }

    public decimal? AmountOfMoneyEnd { get; set; }

    public double? QuantityTest { get; set; }

    public double? QuantityTest15 { get; set; }

    public double? AverageOutput { get; set; }

    public double? AverageOutput15 { get; set; }

    public double? TankLoss { get; set; }

    public double? TankLoss15 { get; set; }

    public double? Inventory { get; set; }

    public double? Inventory15 { get; set; }

    public double? InventoryEnd { get; set; }

    public double? InventoryEnd15 { get; set; }

    public double? Uneven { get; set; }

    public double? Uneven15 { get; set; }

    public double? TotalImp { get; set; }

    public double? TotalImp15 { get; set; }

    public double? TotalExp { get; set; }

    public double? TotalExp15 { get; set; }

    public double? TotalAttr { get; set; }

    public double? TotalAttr15 { get; set; }

    public double? Hh758 { get; set; }

    public double? PercentHh758 { get; set; }

    public double? HhTd { get; set; }

    public double? PercentHhTd { get; set; }

    public double? HhPvoil { get; set; }

    public double? PercentHhPvoil { get; set; }

    public double? HhTt { get; set; }

    public double? PercentHhTt { get; set; }

    public string? EndDate { get; set; }

    public string? BeginDate { get; set; }

    public string? Date { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
