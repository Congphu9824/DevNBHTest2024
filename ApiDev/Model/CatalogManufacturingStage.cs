﻿using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogManufacturingStage
{
    public string StageCode { get; set; } = null!;

    public string? StageName { get; set; }

    public int? Sequential { get; set; }

    public string? StageType { get; set; }

    public string? Notes { get; set; }

    public bool IsUse { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public DateTime Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }
}
