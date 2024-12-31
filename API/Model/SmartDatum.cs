﻿using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SmartDatum
{
    public Guid Id { get; set; }

    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public bool? CostAllotment { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? PersonCode { get; set; }

    public string? PersonName { get; set; }

    public string? PersonAddress { get; set; }

    public string? PersonTaxCode { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectAddress { get; set; }

    public string? ObjectTaxCode { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? WarehoseNameReceive { get; set; }

    public string? ReasonCode { get; set; }

    public string? ReasonName { get; set; }

    public string? ShippingMethodsCode { get; set; }

    public string? ShippingMethodsName { get; set; }

    public string? MethodOfPaymentsCode { get; set; }

    public string? MethodOfPaymentsName { get; set; }

    public string? Description { get; set; }

    public string? Notes { get; set; }

    public bool Pricing { get; set; }

    public bool Einvoice { get; set; }

    public bool? InvocePublished { get; set; }

    public string? KeyInvoce { get; set; }

    public string? EnumberInvoice { get; set; }

    public string? EnumberInvoiceDraft { get; set; }

    public string? InvoiceResult { get; set; }

    public Guid? IdDataInherit { get; set; }

    public bool NotEnvironment { get; set; }

    public string? VehiclesName { get; set; }

    public string? VoucherStatus { get; set; }

    public string? LicensePlates { get; set; }

    public string? InvoiceSymbol { get; set; }

    public string? InvoiceTemplate { get; set; }

    public string? SignTransfer { get; set; }

    public bool Register { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public bool? Selectted { get; set; }

    public bool? InvoiceCancel { get; set; }

    public string? ObjectEmail { get; set; }

    public string? Loaiphieu { get; set; }

    public string? IdDataHead { get; set; }

    public bool? ComfirmVoucher { get; set; }

    public string? VoucherNoInherit { get; set; }

    public string? GroupAreaCode { get; set; }

    public string? GroupAreaName { get; set; }

    public bool Delivered { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ContractNo { get; set; }

    public string? RoomCode { get; set; }

    public string? RoomName { get; set; }

    public bool? Vat { get; set; }

    public bool SaveTemp { get; set; }

    public Guid? IdVoucherSource { get; set; }

    public string? SignAdjust { get; set; }

    public string? MemberRate { get; set; }
}
