using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogWard
{
    public string? CodeDistrict { get; set; }

    public string? NameDistrict { get; set; }

    public string CodeWards { get; set; } = null!;

    public string? NameWards { get; set; }

    public DateTime? BeginDate { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public double? WardsPercent { get; set; }

    public double? ProvincePercent { get; set; }

    public double? CollaboratorPercent { get; set; }
}
