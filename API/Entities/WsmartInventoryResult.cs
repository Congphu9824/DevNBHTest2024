using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class WsmartInventoryResult
{
    public Guid Id { get; set; }

    public string? InvNumber { get; set; }

    public DateTime? InvTime { get; set; }

    public int? IdDonViOk { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string ProductCode { get; set; } = null!;

    public string? ProductName { get; set; }

    public string? UnitPcs { get; set; }

    public double? InStock { get; set; }

    public double? InvCount { get; set; }

    public double? ReCount { get; set; }

    public double? DiffCount { get; set; }

    public double? ErrorCount { get; set; }

    public double? PriceRetail { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? GrpCode { get; set; }

    public string? GrpName { get; set; }

    public string? Notes { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }

    public string? IpAddress { get; set; }

    public string? DeviceName { get; set; }

    public string? CodeUser { get; set; }

    public string? Barcode { get; set; }

    public int? IdSource { get; set; }
}
