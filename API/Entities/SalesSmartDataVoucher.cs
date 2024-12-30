using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SalesSmartDataVoucher
{
    public string? DataName { get; set; }

    public string? WarehoseData { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public int? CodeUnit { get; set; }

    public string? Description { get; set; }

    public string? Warehosecode { get; set; }

    public string? WarehoseName { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectTaxCode { get; set; }

    public string? ObjectName { get; set; }

    public int Quantity { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public string? ObjectAddress { get; set; }

    public string? Notes { get; set; }

    public string? PersonCode { get; set; }

    public string? PersonName { get; set; }

    public string? PersonTaxCode { get; set; }

    public string? PersonAddress { get; set; }

    public int IdAsc { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public string? DataType { get; set; }

    public Guid Id { get; set; }
}
