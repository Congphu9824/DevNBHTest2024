using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class TemplateInDirectCashFlow
{
    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public string? Code { get; set; }

    public string? Targets { get; set; }

    public string? CodeReport { get; set; }

    public string? Formula { get; set; }

    public string? Presentation { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public string? Notes { get; set; }

    public int? LevelSum { get; set; }
}
