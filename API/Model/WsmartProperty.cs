using System;
using System.Collections.Generic;

namespace API.Model;

public partial class WsmartProperty
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public string? IdSource { get; set; }

    public int? ColumnAsc { get; set; }

    public string? CodeField { get; set; }

    public string? NameField { get; set; }

    public bool? IsPrimaryKey { get; set; }

    public bool? IsInvisible { get; set; }

    public bool? IsHideOnMobile { get; set; }

    public bool? IsSearch { get; set; }

    public bool? AllowAdding { get; set; }

    public bool? AllowEditing { get; set; }

    public bool? IsRequired { get; set; }

    public int? EditPosition { get; set; }

    public int? EditSize { get; set; }

    public int? EditSizeMobile { get; set; }

    public string? Width { get; set; }

    public bool? SumAggregate { get; set; }

    public string? DataType { get; set; }

    public string? Format { get; set; }

    public string? DropDownValue { get; set; }

    public string? DropDownText { get; set; }

    public string? DropDownBindValue { get; set; }

    public string? Align { get; set; }

    public string? Color { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? Created { get; set; }
}
