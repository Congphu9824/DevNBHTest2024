using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class TradingCatalogVoucherNumber
{
    public string? DataType { get; set; }

    public string? SignVoucher { get; set; }

    public int? VoucherLength { get; set; }

    public string? VoucherName { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public bool? ByDate { get; set; }

    public bool? VatTab { get; set; }

    public bool? ToolsTab { get; set; }

    public bool? CostTab { get; set; }

    public bool? AttachTab { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool? DataImpExp { get; set; }

    public bool? DataInvoice { get; set; }

    public bool? DataVoucher { get; set; }

    public bool? DataConsign { get; set; }

    public bool NoteError { get; set; }

    public bool SaveDataLogs { get; set; }

    public bool IsPriceImp { get; set; }

    public bool IsFromVoucher { get; set; }

    public bool HasInherit { get; set; }

    public bool ShipmentNumber { get; set; }

    public string? ReasonUse { get; set; }

    public int? NumberDayEditVouchers { get; set; }

    public bool PrintLastSave { get; set; }

    public bool PrintView { get; set; }

    public string? InheritFrom { get; set; }

    public bool Censorship { get; set; }
}
