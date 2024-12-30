using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class ReportFileNameByPrinter
{
    public Guid Id { get; set; }

    public string? PrinterName { get; set; }

    public string? ReportFileName { get; set; }

    public string? TypeOrder { get; set; }

    public string? Note { get; set; }

    public int IdAsc { get; set; }

    public bool IsActive { get; set; }

    public int? RawKind { get; set; }
}
