using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class ResultBkavInvoice
{
    public int Id { get; set; }

    public string? PartnerInvoiceId { get; set; }

    public string? PartnerInvoiceStringId { get; set; }

    public string? InvoiceGuid { get; set; }

    public string? InvoiceForm { get; set; }

    public string? InvoiceSerial { get; set; }

    public string? InvoiceNo { get; set; }

    public string? Mtc { get; set; }

    public string? MaCuaCqt { get; set; }

    public bool? Status { get; set; }

    public string? MessLog { get; set; }
}
