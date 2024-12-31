using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogAccountSymbol
{
    public string AccountSymbol { get; set; } = null!;

    public string? AccountName { get; set; }

    public int? AccountLevel { get; set; }

    public string? AccountType { get; set; }

    public bool Obligatory { get; set; }

    public bool Contract { get; set; }

    public bool Construction { get; set; }

    public bool Project { get; set; }

    public bool RevenueExpense { get; set; }

    public bool ForeignCurrency { get; set; }

    public bool Tools { get; set; }

    public bool Price { get; set; }

    public bool Materials { get; set; }

    public bool Warehose { get; set; }

    public bool Object { get; set; }

    public bool Invoice { get; set; }

    public bool Room { get; set; }

    public bool ProductionActivities { get; set; }

    public bool FundingSource { get; set; }

    public bool AccountAllotment { get; set; }

    public bool Hermaphrodite { get; set; }

    public string? CodeReport { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public bool? Debit { get; set; }

    public bool? Credit { get; set; }

    public bool? NoBalance { get; set; }

    public bool IsTax { get; set; }

    public bool IsNotMerge { get; set; }
}
