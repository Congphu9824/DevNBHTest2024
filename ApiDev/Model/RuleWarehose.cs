using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class RuleWarehose
{
    public string? CodeUser { get; set; }

    public string? CodeWarehose { get; set; }

    public string? NameWarehose { get; set; }

    public bool IsAllow { get; set; }

    public Guid Id { get; set; }

    public string? Notes { get; set; }

    public int IdAsc { get; set; }

    public Guid? UserId { get; set; }
}
