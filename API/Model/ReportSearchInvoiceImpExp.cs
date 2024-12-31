using System;
using System.Collections.Generic;

namespace API.Model;

public partial class ReportSearchInvoiceImpExp
{
    public int Id { get; set; }

    public Guid? IdData { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? DataType { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? AccountSymbol { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? VatType { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? InvoiceSign { get; set; }

    public string? InvoiceTemplate { get; set; }

    public decimal? AmountInVouchers { get; set; }

    public decimal? AmountTaxInVouchers { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public double? VatRate { get; set; }

    public decimal? AmountVat { get; set; }

    public decimal? AmountVatIpx { get; set; }

    public decimal? AmountVatFee { get; set; }

    public decimal? DiffAmount { get; set; }

    public decimal? DiffAmountVat { get; set; }

    public bool IsError { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
