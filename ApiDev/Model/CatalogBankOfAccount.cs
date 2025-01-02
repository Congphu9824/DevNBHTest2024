using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogBankOfAccount
{
    public string? AccountNumber { get; set; }

    public string? BankName { get; set; }

    public string? BankCode { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? Notes { get; set; }

    public string? DataType { get; set; }

    public bool IsActive { get; set; }

    public Guid Identifier { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }
}
