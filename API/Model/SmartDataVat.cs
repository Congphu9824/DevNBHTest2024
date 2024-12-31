using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SmartDataVat
{
    public Guid Id { get; set; }

    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public int IdAsc { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? AccountSymbol { get; set; }

    public string? TaxCode { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public double? VatRate { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? AmountVat { get; set; }

    public string? VatType { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? InvoiceSign { get; set; }

    public string? InvoiceTemplate { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public string? Notes { get; set; }
}
