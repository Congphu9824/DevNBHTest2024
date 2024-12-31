using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SalesShoppingCartContent
{
    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public string? DataType { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public double? VatRate { get; set; }

    public string? Notes { get; set; }

    public Guid? IdData { get; set; }

    public Guid IdSource { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public bool IsAgree { get; set; }

    public bool? CounterConfirmation { get; set; }

    public double? QuantityConfirmation { get; set; }

    public double? NumberFuel { get; set; }

    public double? NumberInvPublish { get; set; }

    public string? BatchWarehose { get; set; }

    public bool IsPromotion { get; set; }
}
