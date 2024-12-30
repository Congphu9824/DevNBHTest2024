using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SalesSmartDataDc
{
    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public string? WarehoseData { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? Notes { get; set; }

    public string? Description { get; set; }

    public string? MethodOfPaymentsName { get; set; }

    public string? MethodOfPaymentsCode { get; set; }

    public string? ReasonName { get; set; }

    public string? ReasonCode { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectCode { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public Guid IdContents { get; set; }

    public double? Price { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public int? CodeUnit { get; set; }

    public string? StaffCode { get; set; }

    public string? StaffName { get; set; }

    public string? Expr1 { get; set; }

    public string? Expr2 { get; set; }

    public string? Expr3 { get; set; }

    public string? Expr4 { get; set; }
}
