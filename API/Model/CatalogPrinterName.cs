using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogPrinterName
{
    public string? PrintName { get; set; }

    public int? RawKind { get; set; }

    public int? LeftMargin { get; set; }

    public int? BottomMargin { get; set; }

    public int? TopMargin { get; set; }

    public int? RightMargin { get; set; }

    public string? Witdh { get; set; }

    public string? Hieght { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }

    public string? Notes { get; set; }
}
