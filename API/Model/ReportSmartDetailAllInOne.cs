using System;
using System.Collections.Generic;

namespace API.Model;

public partial class ReportSmartDetailAllInOne
{
    public int Id { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? NumericalOrder { get; set; }

    public int? MaxNumericalOrder { get; set; }

    public string? SmartSort { get; set; }

    public string? AccountSymbol { get; set; }

    public bool? NoExcel { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public Guid? IdVoucher { get; set; }

    public string? DataType { get; set; }

    public string? Description { get; set; }

    public string? NumberOfVouchers { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? CodeSupplier { get; set; }

    public string? NameSupplier { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? PumpColumnCode { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Price { get; set; }

    public double? PriceBegin { get; set; }

    public double? QuantityBegin { get; set; }

    public decimal? AmountOfMoneyBegin { get; set; }

    public double? PriceImp { get; set; }

    public double? QuantityImp { get; set; }

    public decimal? AmountOfMoneyImp { get; set; }

    public double? PriceImpBuy { get; set; }

    public double? QuantityImpBuy { get; set; }

    public decimal? AmountOfMoneyImpBuy { get; set; }

    public double? PriceImpReturn { get; set; }

    public double? QuantityImpReturn { get; set; }

    public decimal? AmountOfMoneyImpReturn { get; set; }

    public double? PriceImpTransfer { get; set; }

    public double? QuantityImpTransfer { get; set; }

    public decimal? AmountOfMoneyImpTransfer { get; set; }

    public double? PriceImpInventory { get; set; }

    public double? QuantityImpInventory { get; set; }

    public decimal? AmountOfMoneyImpInventory { get; set; }

    public double? PriceImpAnother { get; set; }

    public double? QuantityImpAnother { get; set; }

    public decimal? AmountOfMoneyImpAnother { get; set; }

    public double? PriceImpTemporary { get; set; }

    public double? QuantityImpTemporary { get; set; }

    public decimal? AmountOfMoneyImpTemporary { get; set; }

    public double? PriceExp { get; set; }

    public double? QuantityExp { get; set; }

    public decimal? AmountOfMoneyExp { get; set; }

    public double? PriceExpSell { get; set; }

    public double? QuantityExpSell { get; set; }

    public decimal? AmountOfMoneyExpSell { get; set; }

    public double? PriceExpSellRetail { get; set; }

    public double? QuantityExpSellRetail { get; set; }

    public decimal? AmountOfMoneyExpSellRetail { get; set; }

    public double? PriceExpTransfer { get; set; }

    public double? QuantityExpTransfer { get; set; }

    public decimal? AmountOfMoneyExpTransfer { get; set; }

    public double? PriceExpReturn { get; set; }

    public double? QuantityExpReturn { get; set; }

    public decimal? AmountOfMoneyExpReturn { get; set; }

    public double? PriceExpInventory { get; set; }

    public double? QuantityExpInventory { get; set; }

    public decimal? AmountOfMoneyExpInventory { get; set; }

    public double? PriceExpAnother { get; set; }

    public double? QuantityExpAnother { get; set; }

    public double? QuantityExpSave { get; set; }

    public decimal? AmountOfMoneyExpAnother { get; set; }

    public double? PriceExpTemporary { get; set; }

    public double? QuantityExpTemporary { get; set; }

    public decimal? AmountOfMoneyExpTemporary { get; set; }

    public double? PriceEnd { get; set; }

    public double? QuantityEnd { get; set; }

    public decimal? AmountOfMoneyEnd { get; set; }

    public decimal? VatRate { get; set; }

    public decimal? AmountVat { get; set; }

    public decimal? AmountWithoutVat { get; set; }

    public bool GreaseOil { get; set; }

    public decimal? DebitBalance { get; set; }

    public decimal? DebtBalancBegin { get; set; }

    public decimal? CreditBalancBegin { get; set; }

    public decimal? DebtArise { get; set; }

    public decimal? CreditArise { get; set; }

    public decimal? DebtBalancRemaining { get; set; }

    public decimal? CreditBalancRemaining { get; set; }

    public decimal? DebtBalancEnd { get; set; }

    public decimal? CreditBalancEnd { get; set; }

    public decimal? DebitBalanceUsd { get; set; }

    public decimal? DebtBalancBeginUsd { get; set; }

    public decimal? CreditBalancBeginUsd { get; set; }

    public decimal? DebtAriseUsd { get; set; }

    public decimal? CreditAriseUsd { get; set; }

    public decimal? DebtBalancRemainingUsd { get; set; }

    public decimal? CreditBalancRemainingUsd { get; set; }

    public decimal? DebtBalancEndUsd { get; set; }

    public decimal? CreditBalancEndUsd { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
