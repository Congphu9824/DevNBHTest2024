using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SmartMapColumnExcel
{
    public Guid Id { get; set; }

    public int IdSort { get; set; }

    public string? Parameter { get; set; }

    public string? ColumNameTable { get; set; }

    public string? ColumnNameExcel { get; set; }

    public bool? IsNumber { get; set; }

    public bool? IsDate { get; set; }

    public bool? IsTrueFalse { get; set; }

    public bool? IsMulty { get; set; }

    public string? SignalTrue { get; set; }

    public string? ColumnDataType { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public string? DataType { get; set; }

    public string? TableName { get; set; }

    public Guid? IdKey { get; set; }
}
