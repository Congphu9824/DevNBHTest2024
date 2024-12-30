using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class TradingSmartDatum
{
    public Guid Id { get; set; }

    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? LicensePlates { get; set; }

    public string? VehiclesName { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? NumBerofferToExport { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectAddress { get; set; }

    public string? ObjectTaxCode { get; set; }

    public string? PersonName { get; set; }

    public double? DiscountRate { get; set; }

    public decimal DebitBalance { get; set; }

    public decimal DebtBalanc { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string? Description { get; set; }

    public bool NotEnvironment { get; set; }

    public bool DataHasBeenTaken { get; set; }

    public string? Notes { get; set; }

    public Guid? IdDocumment { get; set; }

    public string? ContractNo { get; set; }

    public DateTime? SignDate { get; set; }

    public string? CitizenIdentification { get; set; }

    public DateTime? DateOfIssue { get; set; }

    public string? PlaceOfIssue { get; set; }

    public string? DecisionNo { get; set; }

    public string? IdTablePrice { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }

    public string? Loaiphieu { get; set; }

    public string? Loaiphieuhd { get; set; }

    public string? MethodOfPaymentsCode { get; set; }

    public string? MethodOfPaymentsName { get; set; }

    public string? ShippingMethodsCode { get; set; }

    public string? ShippingMethodsName { get; set; }

    public bool Register { get; set; }

    public string? LevelDiscount { get; set; }

    public bool Vat { get; set; }

    public bool Finish { get; set; }

    public bool SaveTemp { get; set; }

    public bool MoneyDiscountOnBill { get; set; }

    public string? StaffCode { get; set; }

    public string? StaffName { get; set; }

    public string? CodeMethodExpImp { get; set; }

    public string? NameMethodExpImp { get; set; }

    public string? CodeAppraisal { get; set; }

    public string? NameAppraisal { get; set; }

    public string? WarehoseCodeReceive { get; set; }

    public string? WarehoseNameReceive { get; set; }
}
