using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SmartContentsPromotionArea
{
    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public string? DataType { get; set; }
}
