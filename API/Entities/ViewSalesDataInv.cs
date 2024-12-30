using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class ViewSalesDataInv
{
    public int? CodeUnit { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? DataType { get; set; }

    public string? WarehoseCode { get; set; }

    public decimal? AmountOfMoneyExpSell { get; set; }

    public decimal? AmountOfMoneyExpSellRetail { get; set; }

    public decimal? AmountOfMoneyImpReturn { get; set; }
}
