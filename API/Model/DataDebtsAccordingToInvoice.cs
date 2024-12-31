using System;
using System.Collections.Generic;

namespace API.Model;

public partial class DataDebtsAccordingToInvoice
{
    public Guid Id { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? DebitObjectCode { get; set; }

    public string? DebitObjectName { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? NumberOfVouchers { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public int? CodeUnit { get; set; }

    public int IdAsc { get; set; }
}
