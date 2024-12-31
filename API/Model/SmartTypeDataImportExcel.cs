using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SmartTypeDataImportExcel
{
    public string DataType { get; set; } = null!;

    public string? DataName { get; set; }

    public string? TableName { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
