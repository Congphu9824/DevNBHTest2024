using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogVillage
{
    public string? CodeWards { get; set; }

    public string? NameWards { get; set; }

    public string CodeVillage { get; set; } = null!;

    public string? NameVillage { get; set; }

    public string? CodeObj { get; set; }

    public string? NameObj { get; set; }

    public DateTime? BeginDate { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
