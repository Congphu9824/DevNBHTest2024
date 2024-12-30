using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SalesListBillImpReturn
{
    public Guid Id { get; set; }

    public int? CodeUnit { get; set; }

    public string? WarehoseCode { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public decimal? AmountOfMoney { get; set; }
}
