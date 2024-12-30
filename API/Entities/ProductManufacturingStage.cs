using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class ProductManufacturingStage
{
    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? StageCode { get; set; }

    public string? StageName { get; set; }

    public int? Sequential { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }
}
