using System;
using System.Collections.Generic;

namespace API.Model;

public partial class TempSmartTable
{
    public Guid Id { get; set; }

    public bool? IsActive { get; set; }

    public string? CodeWarehose { get; set; }

    public string? PumpColumnCode { get; set; }

    public string? PumpColumnName { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public double? NumberBegin { get; set; }

    public double? NumberEnd { get; set; }

    public double? PriceWithoutVat { get; set; }

    public double? Price { get; set; }

    public double? VatRate { get; set; }

    public double? QuantityConsignmentGoods { get; set; }

    public double? QuantityTest { get; set; }

    public double? QuantityInternal { get; set; }

    public double? QuantityRetail { get; set; }

    public double? QuantityContract { get; set; }

    public double? Quantity { get; set; }

    public decimal? AmountVat { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? AmountDiscount { get; set; }

    public decimal? ActualAmount { get; set; }
}
