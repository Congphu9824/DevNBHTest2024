using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogInvoiceInfo
{
    public Guid Id { get; set; }

    public int? CodeUnit { get; set; }

    public string? CodeUser { get; set; }

    public string? UrlApi { get; set; }

    public string? UserApi { get; set; }

    public string? PasswordApi { get; set; }

    public string? InvSymbol { get; set; }

    public string? InvForm { get; set; }

    public string? InvTemplate { get; set; }

    public bool NoSign { get; set; }

    public bool IsInvoiceCalculatingMachine { get; set; }

    public bool HasMetadata { get; set; }

    public bool TowProcess { get; set; }

    public string? PartnerGuid { get; set; }

    public string? PartnerToken { get; set; }

    public string? AppKey { get; set; }

    public string? UserAc { get; set; }

    public string? PasswordAc { get; set; }

    public string? UrlBusiness { get; set; }

    public string? UrlPortal { get; set; }

    public string? Notes { get; set; }

    public string? TaxCode { get; set; }
}
