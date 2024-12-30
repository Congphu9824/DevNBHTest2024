using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogSelecttedPrint
{
    public string? CatalogName { get; set; }

    public string? ValueSelectted { get; set; }

    public string? UserCode { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public double? AmountFrom { get; set; }

    public double? AmountEnd { get; set; }

    public double? MoneyFrom { get; set; }

    public double? MoneyEnd { get; set; }
}
