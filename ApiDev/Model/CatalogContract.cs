using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogContract
{
    public string? GrpCode { get; set; }

    public string? GrpName { get; set; }

    public string ContractNumber { get; set; } = null!;

    public string? ContentContract { get; set; }

    public DateTime? SigningDate { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? ValueContract { get; set; }

    public string? ReferenceNumber { get; set; }

    public DateTime? GuaranteeDate { get; set; }

    public decimal? GuaranteeValue { get; set; }

    public string? CodePartner { get; set; }

    public string? NamePartner { get; set; }

    public string? CodeManage { get; set; }

    public string? NameManage { get; set; }

    public string? CodeManage1 { get; set; }

    public string? NameManage1 { get; set; }

    public bool IsEnd { get; set; }

    public string? CurrencyType { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public string? ProductActivCode { get; set; }

    public string? ProductActivName { get; set; }

    public DateTime? MaintenanceDate { get; set; }

    public int? MonthsMaintenance { get; set; }

    public decimal? ValuesMaintenance { get; set; }

    public bool IsPayed { get; set; }
}
