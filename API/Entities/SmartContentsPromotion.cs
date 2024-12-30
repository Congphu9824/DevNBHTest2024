using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SmartContentsPromotion
{
    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? DiscountRate { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public string? DataType { get; set; }
}
