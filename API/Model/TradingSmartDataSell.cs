using System;
using System.Collections.Generic;

namespace API.Model;

public partial class TradingSmartDataSell
{
    public Guid Id { get; set; }

    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? LicensePlates { get; set; }

    public string? VehiclesName { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectAddress { get; set; }

    public string? ObjectTaxCode { get; set; }

    public string? PersonName { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? Description { get; set; }

    public bool NotEnvironment { get; set; }

    public string? Notes { get; set; }

    public Guid? IdDocumment { get; set; }

    public string? ContractNo { get; set; }

    public DateTime? SignDate { get; set; }

    public DateTime? DateOfIssue { get; set; }

    public string? PlaceOfIssue { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public string? CitizenIdentification { get; set; }

    public string? CommodityCode { get; set; }

    public int IdAscContenst { get; set; }

    public string? CommodityName { get; set; }

    public string? UnitPcs { get; set; }

    public double? Quantity { get; set; }

    public double? Quantity15 { get; set; }

    public double? Price { get; set; }

    public double? PriceWithoutVat { get; set; }

    public double? PriceAfterDiscount { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? AmountVat { get; set; }

    public decimal? AmountWithoutVat { get; set; }

    public double? FeeEnvironRate { get; set; }

    public decimal? AmountFeeEnvironRate { get; set; }

    public decimal? AmountWithoutVatFee { get; set; }

    public double? PriceWithoutVatFee { get; set; }

    public double? VatRate { get; set; }

    public decimal? AmountDiscount { get; set; }

    public double? DiscountRate { get; set; }

    public decimal? AmountAfterDiscount { get; set; }

    public decimal? ActualAmount { get; set; }

    public double? CoefficientVcf { get; set; }

    public double? Temperature { get; set; }

    public double? CoefficientWcf { get; set; }

    public string? NotesContest { get; set; }

    public bool IsActive { get; set; }

    public Guid IdSource { get; set; }

    public Guid? IdData { get; set; }

    public string? NumBerofferToExport { get; set; }

    public bool DataHasBeenTaken { get; set; }

    public double? Price1 { get; set; }

    public double? Price2 { get; set; }

    public double? DiscountRate1 { get; set; }

    public double? DiscountRate2 { get; set; }
}
