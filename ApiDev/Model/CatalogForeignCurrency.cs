using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogForeignCurrency
{
    public string? ForeignCurrencyType { get; set; }

    public double? ExchangeRate { get; set; }

    public bool IsActive { get; set; }

    public Guid Id { get; set; }

    public int? CodeUnit { get; set; }

    public int IdAsc { get; set; }

    public string? Notes { get; set; }
}
