using System;
using System.Collections.Generic;

namespace API.Model;

public partial class ReportPrintSalesNew
{
    public int Id { get; set; }

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

    public string? TaxCode { get; set; }

    public string? Description { get; set; }

    public bool? NoExcel { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? AccountSymbol { get; set; }

    public string? AccountName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? WarehoseNameReceive { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? RevenueExpenseCode { get; set; }

    public string? RevenueExpenseName { get; set; }

    public double? NumberofInventories { get; set; }

    public double? Quantity15 { get; set; }

    public double? QuantityImp { get; set; }

    public double? QuantityImpGas { get; set; }

    public double? QuantityImpOil { get; set; }

    public decimal? AmountOfMoneyImpGas { get; set; }

    public decimal? AmountOfMoneyImpOil { get; set; }

    public decimal? AmountOfMoneyImp { get; set; }

    public double? QuantityExp { get; set; }

    public double? QuantityExpGas { get; set; }

    public double? QuantityExpOil { get; set; }

    public decimal? AmountOfMoneyExpGas { get; set; }

    public decimal? AmountOfMoneyExpOil { get; set; }

    public decimal? AmountOfMoneyExp { get; set; }

    public decimal? Lg01 { get; set; }

    public decimal? Dccl01 { get; set; }

    public decimal? Qln0102 { get; set; }

    public decimal? Kvc0405 { get; set; }

    public decimal? All1112 { get; set; }

    public double? QuantitySs { get; set; }

    public double? QuantitySs15 { get; set; }

    public double? CostOfGoodsSold { get; set; }

    public double? PriceCost { get; set; }

    public double? Uneven { get; set; }

    public double? Uneven15 { get; set; }

    public double? Vat { get; set; }

    public string? VatName { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public double? QuantityA95 { get; set; }

    public double? PriceA95 { get; set; }

    public decimal? AmountOfMoneyA95 { get; set; }

    public double? QuantityA92 { get; set; }

    public double? PriceA92 { get; set; }

    public decimal? AmountOfMoneyA92 { get; set; }

    public double? QuantityE5 { get; set; }

    public double? PriceE5 { get; set; }

    public decimal? AmountOfMoneyE5 { get; set; }

    public double? QuantityDo { get; set; }

    public double? PriceDo { get; set; }

    public decimal? AmountOfMoneyDo { get; set; }

    public double? QuantityFo { get; set; }

    public double? PriceFo { get; set; }

    public decimal? AmountOfMoneyFo { get; set; }

    public double? QuantityKhac { get; set; }

    public double? PriceKhac { get; set; }

    public decimal? AmountOfMoneyKhac { get; set; }

    public double? QuantityThang { get; set; }

    public double? PriceThang { get; set; }

    public decimal? AmountOfMoneyThang { get; set; }

    public double? QuantityNam { get; set; }

    public double? PriceNam { get; set; }

    public decimal? AmountOfMoneyNam { get; set; }

    public decimal? AmountOfMoneyBegin { get; set; }

    public decimal? AmountDiscount { get; set; }

    public decimal? AmountEnvironmentax { get; set; }

    public decimal? AmountVat { get; set; }

    public decimal? AmountPit { get; set; }

    public decimal? AmountCit { get; set; }

    public decimal? AmountTax { get; set; }

    public decimal? AmountFixedCosts { get; set; }

    public decimal? AmountVariablCosts { get; set; }

    public decimal? DebitBalance { get; set; }

    public decimal? DebtBalancBegin { get; set; }

    public decimal? CreditBalancBegin { get; set; }

    public decimal? DebtArise { get; set; }

    public decimal? CreditArise { get; set; }

    public decimal? DebtBalancRemaining { get; set; }

    public decimal? CreditBalancRemaining { get; set; }

    public decimal? DebtBalancEnd { get; set; }

    public decimal? CreditBalancEnd { get; set; }

    public string? DebitObjectCode { get; set; }

    public string? DebitObjectName { get; set; }

    public string? CreditObjectCode { get; set; }

    public string? CreditObjectName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public string? EndDate { get; set; }

    public string? BeginDate { get; set; }

    public string? DayText { get; set; }

    public string? MonthText { get; set; }

    public string? Note { get; set; }

    public string? Note1 { get; set; }

    public string? Note2 { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
