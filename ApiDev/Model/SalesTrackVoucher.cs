using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SalesTrackVoucher
{
    public Guid? IdVouchers { get; set; }

    public string? SrcDataName { get; set; }

    public Guid Id { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime CreateDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public string? Description { get; set; }
}
