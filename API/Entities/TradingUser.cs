using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class TradingUser
{
    public Guid Id { get; set; }

    public int? CodeUnit { get; set; }

    public string CodeUser { get; set; } = null!;

    public string? NameUser { get; set; }

    public string? PassUser { get; set; }

    public string? WarehoseData { get; set; }

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
}
