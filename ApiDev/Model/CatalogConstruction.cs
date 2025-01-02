using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogConstruction
{
    public string? ProjectCode { get; set; }

    public string? ProjectName { get; set; }

    public string? GrpCode { get; set; }

    public string? GrpName { get; set; }

    public string ConstructionCode { get; set; } = null!;

    public string? ConstructionName { get; set; }

    public decimal? ValueConstruction { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }
}
