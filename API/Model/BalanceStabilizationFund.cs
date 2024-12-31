using System;
using System.Collections.Generic;

namespace API.Model;

public partial class BalanceStabilizationFund
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Contents { get; set; }

    public double? GasolineA92 { get; set; }

    public double? GasolineA95 { get; set; }

    public double? OilDiezen { get; set; }

    public double? Gas { get; set; }

    public double? OilMazut { get; set; }

    public double? TotalBalance { get; set; }

    public string? Note { get; set; }

    public decimal? Profit { get; set; }
}
