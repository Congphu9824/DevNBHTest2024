using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class WsmartInventoryResultsAll
{
    public Guid Id { get; set; }

    public string DataType { get; set; } = null!;

    public string? WarehoseData { get; set; }

    public string? NumberOfVouchers { get; set; }

    public DateTime? RecordDate { get; set; }

    public int? CodeUnit { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string ProductCode { get; set; } = null!;

    public string? Barcode { get; set; }

    public string? ProductName { get; set; }

    public double? InStock { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? Notes { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }

    public string? IpAddress { get; set; }

    public string? DeviceName { get; set; }

    public string? CodeUser { get; set; }

    public double Quantity { get; set; }

    public double ErrorCount { get; set; }

    public double Price { get; set; }

    public double AmountOfMoney { get; set; }
}
