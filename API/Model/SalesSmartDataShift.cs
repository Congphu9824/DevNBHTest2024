using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SalesSmartDataShift
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

    public string? PersonCode { get; set; }

    public string? PersonName { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public string? Description { get; set; }

    public string? ReasonCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? ObjectTaxCode { get; set; }

    public string? ObjectAddress { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectCode { get; set; }

    public string? PersonTaxCode { get; set; }

    public string? PersonAddress { get; set; }

    public string? PumpColumnCode { get; set; }

    public string? PumpColumnName { get; set; }

    public double? NumberBegin { get; set; }

    public double? NumberEnd { get; set; }

    public string? CommodityCode { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? QuantityConsignmentGoods { get; set; }

    public double? QuantityTest { get; set; }

    public double? QuantityInternal { get; set; }

    public double? QuantityContract { get; set; }

    public double? QuantityRetail { get; set; }

    public double? Quantity { get; set; }

    public double? Quantity15 { get; set; }

    public double? Price { get; set; }

    public double? PriceWithoutVat { get; set; }

    public double? PriceAfterDiscount { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? AmountVat { get; set; }

    public decimal? AmountWithoutVat { get; set; }

    public double? VatRate { get; set; }

    public decimal? AmountDiscount { get; set; }

    public decimal? AmountAfterDiscount { get; set; }

    public double? FeeEnvironRate { get; set; }

    public decimal? AmountFeeEnvironRate { get; set; }

    public double? CoefficientVcf { get; set; }

    public double? Temperature { get; set; }

    public double? CoefficientWcf { get; set; }

    public string? DescriptionContents { get; set; }

    public double? DiscountRate { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }
}
