using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class DataFieldUser
{
    public Guid Id { get; set; }

    public string? UserCode { get; set; }

    public int? CodeUnit { get; set; }

    public string? TableName { get; set; }

    public string? LoaiPhieu { get; set; }

    public string? ColumnName { get; set; }

    public string? DataType { get; set; }

    public string? DisplayText { get; set; }

    public string? FormatText { get; set; }

    public string? TextAlign { get; set; }

    public string? ForeColor { get; set; }

    public bool? CheckBoxVisibility { get; set; }

    public bool? FontDataBold { get; set; }

    public bool? FontDataItalic { get; set; }

    public bool? IsSum { get; set; }

    public string? FomatSum { get; set; }

    public bool? IsHide { get; set; }

    public bool? IsSearch { get; set; }

    public int? PositionSearch { get; set; }

    public int? Width { get; set; }

    public string? GroupKey { get; set; }

    public string? GroupText { get; set; }

    public string? CellClickAction { get; set; }

    public bool ButtonClick { get; set; }

    public string? BackColor { get; set; }

    public string? ViewColor { get; set; }

    public bool CellMultiLine { get; set; }

    public bool TabStop { get; set; }

    public string? Formula { get; set; }

    public string? NullText { get; set; }

    public bool? CellUpper { get; set; }

    public bool? DoubleClickCell { get; set; }

    public string? Note { get; set; }

    public string? CellActivation { get; set; }
}
