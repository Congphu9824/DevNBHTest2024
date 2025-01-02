using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SalesRuleReport
{
    public Guid Id { get; set; }

    public int? CodeUnit { get; set; }

    public string? CodeReport { get; set; }

    public string? NameReport { get; set; }

    public string? CodeUser { get; set; }

    public bool AllowView { get; set; }

    public string? Notes { get; set; }
}
