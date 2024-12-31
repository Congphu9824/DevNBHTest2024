using System;
using System.Collections.Generic;

namespace API.Model;

public partial class WsmartFieldProperty
{
    public Guid Id { get; set; }

    public int? IdAsc { get; set; }

    public string? IdGridSetting { get; set; }

    public string? CodeField { get; set; }

    public string? NameField { get; set; }

    public bool? IsPrimaryKey { get; set; }

    public bool? IsInvisible { get; set; }

    public bool? IsHideOnMobile { get; set; }

    public bool? IsSearch { get; set; }

    public string? Width { get; set; }

    public bool? SumAggregate { get; set; }

    public string? DataType { get; set; }

    public string? Format { get; set; }

    public string? Align { get; set; }

    public string? Color { get; set; }
}
