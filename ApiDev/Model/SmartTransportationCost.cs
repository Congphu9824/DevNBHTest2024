using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SmartTransportationCost
{
    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? VoucherNumberContents { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? AccountSymbol { get; set; }

    public string? TaxCode { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public double? VatRate { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? AmountAllotment { get; set; }

    public decimal? AmountAccumulated { get; set; }

    public string? Description { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public Guid? IdSource { get; set; }

    public string? IdData { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }
}
