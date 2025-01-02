using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class ViewSalesDataDetailsInv
{
    public int? CodeUnit { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? DataType { get; set; }

    public string? CommodityCode { get; set; }

    public string? WarehoseCode { get; set; }

    public double? VatRate { get; set; }

    public double? Quantity { get; set; }

    public decimal? AmountOfMoneyExpSell { get; set; }

    public decimal? AmountOfMoneyExpSellRetail { get; set; }

    public decimal? AmountOfMoneyImpReturn { get; set; }

    public double? AmountOfMoneyImp { get; set; }
}
