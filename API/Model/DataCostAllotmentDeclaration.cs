using System;
using System.Collections.Generic;

namespace API.Model;

public partial class DataCostAllotmentDeclaration
{
    public bool IsActive { get; set; }

    public bool? CostAllotment { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? Description { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public decimal? AmountOfMoney { get; set; }
}
