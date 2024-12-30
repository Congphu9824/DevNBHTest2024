using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class AabsalesMenu
{
    public string? TableName { get; set; }

    public string? MenuName { get; set; }

    public string? MenuCaption { get; set; }

    public string? MenuLevel { get; set; }

    public string? ParentMenu { get; set; }

    public string? MenuImage { get; set; }

    public string? MenuParameters { get; set; }

    public bool? IsActive { get; set; }

    public bool? MenuToolBar { get; set; }

    public bool? LeftMenu { get; set; }

    public string? MenuNote { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsNotRule { get; set; }

    public bool UseForRule { get; set; }

    public string? ParameterReport { get; set; }

    public bool ViewDeltail { get; set; }
}
