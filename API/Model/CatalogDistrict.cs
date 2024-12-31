using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogDistrict
{
    public string? CodeProvince { get; set; }

    public string? NameProvince { get; set; }

    public string CodeDistrict { get; set; } = null!;

    public string? NameDistrict { get; set; }

    public DateTime? BeginDate { get; set; }

    public string? CodeObj { get; set; }

    public string? NameObj { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
