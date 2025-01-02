using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SmartManufacture
{
    public Guid Id { get; set; }

    public bool IsActive { get; set; }

    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? PersonCode { get; set; }

    public string? PersonName { get; set; }

    public string? StageName { get; set; }

    public string? StageCode { get; set; }

    public string? PersonAddress { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectAddress { get; set; }

    public string? WarehoseData { get; set; }

    public string? WarehoseName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? WarehoseNameReceive { get; set; }

    public string? ReasonCode { get; set; }

    public string? ReasonName { get; set; }

    public string? Description { get; set; }

    public string? StaffName { get; set; }

    public string? StaffCode { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public bool Register { get; set; }

    public int IdAsc { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public string? IdDataHead { get; set; }

    public bool? ComfirmVoucher { get; set; }

    public string? VoucherNoInherit { get; set; }

    public bool Delivered { get; set; }

    public bool SaveTemp { get; set; }

    public Guid? IdVoucherSource { get; set; }

    public Guid IdContents { get; set; }

    public int IdAscContents { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? UnitPcs { get; set; }

    public double? QuantityOfInventory { get; set; }

    public double? Quantity { get; set; }

    public double? QuantityNotGood { get; set; }

    public double? Weight { get; set; }

    public double? WeightNotGood { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public string? NotesContents { get; set; }

    public Guid? IdData { get; set; }

    public Guid IdSource { get; set; }

    public Guid? IdVouchers { get; set; }

    public Guid IdTracing { get; set; }
}
