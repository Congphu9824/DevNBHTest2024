using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SalesDataInvoice
{
    public Guid Id { get; set; }

    public string? DeliveryPointCode { get; set; }

    public string? Apitaxcode { get; set; }

    public string? Apiuser { get; set; }

    public string? Apiurl { get; set; }

    public string? Apipassword { get; set; }

    public string? Idinvoice { get; set; }

    public string? HiloUserName { get; set; }

    public string? NumberOfVouchers { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? InvoiceSymbol { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? InvoiceTemplate { get; set; }

    public bool Einvoice { get; set; }

    public string? KeyInvoce { get; set; }

    public string? EnumberInvoice { get; set; }

    public string? EnumberInvoiceDraft { get; set; }

    public string? InvoiceResult { get; set; }

    public bool? InvocePublished { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? ObjectTaxCode { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectAddress { get; set; }

    public string? PersonName { get; set; }

    public string? MethodOfPaymentsCode { get; set; }

    public string? MethodOfPaymentsName { get; set; }

    public DateTime CreateDate { get; set; }

    public string? StaffCode { get; set; }

    public string? StaffName { get; set; }

    public string? Notes { get; set; }

    public string? ObjectEmail { get; set; }

    public DateTime DateCreateInvoice { get; set; }
}
