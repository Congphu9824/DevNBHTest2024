using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class WsmartMenuRule
{
    public Guid Id { get; set; }

    public string? UserId { get; set; }

    public string? Mid { get; set; }

    public string? Alias { get; set; }

    public bool IsActive { get; set; }

    public Guid? MgMid { get; set; }

    public string? MgName { get; set; }

    public string? Note { get; set; }
}
