using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SmartDataManufacture
{
    public Guid Id { get; set; }

    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? StageCode { get; set; }

    public string? StageName { get; set; }

    public string? PersonCode { get; set; }

    public string? PersonName { get; set; }

    public string? PersonAddress { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectAddress { get; set; }

    public string? WarehoseData { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? WarehoseNameReceive { get; set; }

    public string? ReasonCode { get; set; }

    public string? ReasonName { get; set; }

    public string? Description { get; set; }

    public string? StaffName { get; set; }

    public string? StaffCode { get; set; }

    public string? Notes { get; set; }

    public bool Register { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public string? ObjectEmail { get; set; }

    public string? IdDataHead { get; set; }

    public bool? ComfirmVoucher { get; set; }

    public string? VoucherNoInherit { get; set; }

    public bool Delivered { get; set; }

    public bool SaveTemp { get; set; }

    public Guid? IdVoucherSource { get; set; }

    public string? VoucherStatus { get; set; }
}
