using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SalesRuleUnit
{
    public string? CodeUser { get; set; }

    public int? CodeUnitOk { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public bool IsAllow { get; set; }

    public Guid Id { get; set; }

    public string? Notes { get; set; }

    public int IdAsc { get; set; }
}
