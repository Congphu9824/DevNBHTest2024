using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogTemplateExcel
{
    public string TemplateExcelCode { get; set; } = null!;

    public string? TemplateExcelName { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }
}
