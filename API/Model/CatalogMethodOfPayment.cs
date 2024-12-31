using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogMethodOfPayment
{
    public string MethodOfPaymentsCode { get; set; } = null!;

    public string? MethodOfPaymentsName { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? TypePayments { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }
}
