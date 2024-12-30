using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SalesTradingOptionPrintOrder
{
    public Guid Id { get; set; }

    public string? TypeDoc { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameDoc { get; set; }

    public string? FileDoc { get; set; }

    public string? Prameters { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Notes { get; set; }
}
