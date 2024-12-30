using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SmartOption
{
    public Guid Id { get; set; }

    public int? CodeUnit { get; set; }

    public string OpType { get; set; } = null!;

    public string? Contenst { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public int IdAsc { get; set; }

    public string? ObjectUse { get; set; }
}
