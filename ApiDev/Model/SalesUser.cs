using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SalesUser
{
    public Guid Id { get; set; }

    public int? CodeUnit { get; set; }

    public string CodeUser { get; set; } = null!;

    public string? NameUser { get; set; }

    public string? PassUser { get; set; }

    public string? CodeWarehose { get; set; }

    public string? NameWarehose { get; set; }

    public string? AddressWarehose { get; set; }

    public string? ManagerName { get; set; }

    public string? AccountName { get; set; }

    public bool IsAdmin { get; set; }

    public bool IsMode { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public int IdAsc { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public bool? OverProvince { get; set; }

    public string? CostAcc { get; set; }

    public string? DebitAcc { get; set; }

    public string? VatAccount { get; set; }

    public string? TaxRevenue { get; set; }

    public string? TaxEnviPro { get; set; }

    public string? IdInvoice { get; set; }

    public string? Apiurl { get; set; }

    public string? Apiuser { get; set; }

    public string? Apipassword { get; set; }

    public string? Apitaxcode { get; set; }

    public string? DeliveryPointCode { get; set; }

    public string? HiloUserName { get; set; }

    public string? EmailUser { get; set; }

    public string? ModeType { get; set; }

    public string? SignWarehose { get; set; }

    public string? ModeTypeName { get; set; }

    public string? PartnerGuid { get; set; }

    public string? PartnerToken { get; set; }

    public string? InvoiceForm { get; set; }

    public string? InvoiceSerial { get; set; }

    public string? TemplateCode { get; set; }

    public bool HasMetadata { get; set; }

    public string? NotInvIdInvoice { get; set; }

    public string? NotInvCodePointExp { get; set; }

    public string? NotInvNamePointExp { get; set; }

    public bool TowProcess { get; set; }

    public bool AutoPublish { get; set; }

    public bool IsInvoiceCalculatingMachine { get; set; }

    public bool? IsConfirmCart { get; set; }
}
