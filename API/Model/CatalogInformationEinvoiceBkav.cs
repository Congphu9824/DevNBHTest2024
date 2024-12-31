using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogInformationEinvoiceBkav
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public string? PartnerToken { get; set; }

    public Guid? PartnerGuid { get; set; }

    public string? UserName { get; set; }

    public string? LinkService { get; set; }

    public string? PasswordApi { get; set; }

    public string? Notes { get; set; }

    public bool IsSales { get; set; }

    public string? InvoiceForm { get; set; }

    public string? InvoiceSerial { get; set; }

    public string? InvPartnerGuid { get; set; }

    public string? InvPartnerToken { get; set; }

    public string? UrlInvInput { get; set; }

    public string? TaxCode { get; set; }

    public bool IsRegister { get; set; }

    public bool IsDisconnect { get; set; }
}
