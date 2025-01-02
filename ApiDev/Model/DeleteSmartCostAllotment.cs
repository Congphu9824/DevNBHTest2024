using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class DeleteSmartCostAllotment
{
    public int IdAsc { get; set; }

    public Guid IdContents { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public string? UnitPackage { get; set; }

    public double? ConversionFactor { get; set; }

    public double? QuantityOfInventory { get; set; }

    public double? Quantity { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfAllotment { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public string? IdData { get; set; }

    public string? NumberOfVouchers { get; set; }
}
