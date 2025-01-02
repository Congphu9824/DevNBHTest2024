using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SalesSmartVoucherImpReturn
{
    public Guid Id { get; set; }

    public int? CodeUnit { get; set; }

    public Guid? IdVouchers { get; set; }
}
