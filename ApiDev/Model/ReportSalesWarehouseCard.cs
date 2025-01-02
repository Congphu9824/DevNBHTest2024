using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class ReportSalesWarehouseCard
{
    public int Id { get; set; }

    public bool? NoExcel { get; set; }

    public int? NumericalOrder { get; set; }

    public int? MaxNumericalOrder { get; set; }

    public string? SmartSort { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public string? DataType { get; set; }

    public Guid? IdVoucher { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? VoucherDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? Description { get; set; }

    public string? WarehoseData { get; set; }

    public string? WarehoseDataName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public double? CoefficientVcf { get; set; }

    public double? Temperature { get; set; }

    public double? CoefficientWcf { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Price { get; set; }

    public string? AccountSymbol { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? AccountName { get; set; }

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

    public double? QuantityAttritionImp { get; set; }

    public double? QuantityAttritionImp15 { get; set; }

    public double? QuantityAttritionExp { get; set; }

    public double? QuantityAttritionExp15 { get; set; }

    public double? TankLoss { get; set; }

    public double? TankLoss15 { get; set; }

    public double? PriceEnd { get; set; }

    public double? QuantityEnd { get; set; }

    public double? QuantityEnd15 { get; set; }

    public decimal? AmountOfMoneyEnd { get; set; }

    public double? QuantityTest { get; set; }

    public double? QuantityTest15 { get; set; }

    public double? AverageOutput { get; set; }

    public double? AverageOutput15 { get; set; }

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

    public string? EndDate { get; set; }

    public string? BeginDate { get; set; }

    public string? Date { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
