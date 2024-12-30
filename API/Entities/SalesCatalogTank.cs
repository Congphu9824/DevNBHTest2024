using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SalesCatalogTank
{
    public string TankCode { get; set; } = null!;

    public string? TankName { get; set; }

    public string? Notes { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? CodeWarehose { get; set; }

    public string? NameWarehose { get; set; }

    public string? UnitPsc { get; set; }

    public double? Capacity { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    /// <summary>
    /// Cột ngày tạo
    /// </summary>
    public DateTime Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }
}
