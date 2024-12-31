using System;
using System.Collections.Generic;

namespace API.Model;

public partial class ParameterReport
{
    public string? DataType { get; set; }

    public string? Parameter { get; set; }

    public string? StoreName { get; set; }

    public string? DisplayText { get; set; }

    public string? TextColumn1 { get; set; }

    public string? TextColumn2 { get; set; }

    public string? TextColumn3 { get; set; }

    public string? TextColumn4 { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool? IsSales { get; set; }

    public bool IsActive { get; set; }
}
