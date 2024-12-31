using System;
using System.Collections.Generic;

namespace API.Model;

public partial class DataTracingVoucher
{
    public string SmartType { get; set; } = null!;

    public Guid Id { get; set; }

    public string? DataType { get; set; }

    public Guid IdSource { get; set; }
}
