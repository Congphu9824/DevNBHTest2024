using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SalesCatalogVcfd15
{
    public string CommodityCode { get; set; } = null!;

    public string? CommodityName { get; set; }

    public string? UnitPsc { get; set; }

    public double? D15 { get; set; }

    public double? Temperature { get; set; }

    public double? Vcf { get; set; }

    public string? MonthText { get; set; }

    public string? Notes { get; set; }

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
