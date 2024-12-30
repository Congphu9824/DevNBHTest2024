using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SalesSmartDataInheritedDocument
{
    public Guid? IdData { get; set; }

    public Guid Id { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? DataType { get; set; }

    public string? DataName { get; set; }
}
