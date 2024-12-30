using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogProject
{
    public string ProjectCode { get; set; } = null!;

    public string? ProjectName { get; set; }

    public string? OwnerOfProjectCode { get; set; }

    public string? OwnerOfProjectName { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? ValueProject { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public string? ProductActivCode { get; set; }

    public string? ProductActivName { get; set; }
}
