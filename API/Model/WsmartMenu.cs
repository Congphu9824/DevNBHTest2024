using System;
using System.Collections.Generic;

namespace API.Model;

public partial class WsmartMenu
{
    public Guid Id { get; set; }

    public string? MenuLevel { get; set; }

    public string? Href { get; set; }

    public string? Icon { get; set; }

    public string? DisPlay { get; set; }

    public string? Match { get; set; }

    public bool IsGroup { get; set; }

    public bool IsActive { get; set; }

    public string? IconMobile { get; set; }
}
