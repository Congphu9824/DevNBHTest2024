using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogBankAccountNumber
{
    public string? Bancode { get; set; }

    public string BankAccountNumbers { get; set; } = null!;

    public string? BankCode { get; set; }

    public string? BankName { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public string? BranchName { get; set; }

    public string? NameUnit { get; set; }

    public string? AccountName { get; set; }

    public string? Notes { get; set; }
}
