using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SalesShoppingCart
{
    public Guid Id { get; set; }

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

    public int? CartStatus { get; set; }
}
