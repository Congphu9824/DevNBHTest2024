using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SmartDataShoppingCart
{
    public Guid Id { get; set; }

    public int? CartStatus { get; set; }

    public string? UserCode { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public double? TotalAmount { get; set; }

    public string? DataType { get; set; }

    public Guid IdContents { get; set; }

    public int IdAscContents { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public double? VatRate { get; set; }

    public string? NoteContents { get; set; }

    public Guid? IdData { get; set; }

    public Guid IdSource { get; set; }

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
