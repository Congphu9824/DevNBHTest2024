using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class TempDataBalanceSheet
{
    public int Id { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? AccountSymbol { get; set; }

    public decimal? DebtBalancEnd { get; set; }

    public decimal? CreditBalancEnd { get; set; }

    public string? Time { get; set; }
}
