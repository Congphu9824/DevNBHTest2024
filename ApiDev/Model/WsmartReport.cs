using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class WsmartReport
{
    public Guid Id { get; set; }

    public string? CodeReport { get; set; }

    public string? NameReport { get; set; }

    public string? TableReport { get; set; }

    public string? StoredProcedure { get; set; }

    public string? Parameter { get; set; }

    public string? RequiredField { get; set; }

    public string? ColumnPosition { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }
}
