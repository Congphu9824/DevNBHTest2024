using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogCommandType
{
    public string? CmdType { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? StatusInvoice { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public Guid Identifier { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }
}
