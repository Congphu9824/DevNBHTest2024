using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SalesSmartDataInventory
{
    public int IdAsc { get; set; }

    public Guid IdContents { get; set; }

    public string? DataType { get; set; }

    public Guid Id { get; set; }

    public string? DataName { get; set; }

    public string? WarehoseData { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public string? Description { get; set; }

    public string? WarehoseName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? PumpColumnCode { get; set; }

    public string? PumpColumnName { get; set; }

    public double? NumberBegin { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public double? Quantity15 { get; set; }

    public double? CoefficientVcf { get; set; }

    public double? Temperature { get; set; }

    public double? CoefficientWcf { get; set; }

    public string? DescriptionContents { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }
}
