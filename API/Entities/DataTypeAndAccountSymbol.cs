using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class DataTypeAndAccountSymbol
{
    public Guid IdContents { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }
}
