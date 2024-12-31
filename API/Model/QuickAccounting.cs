using System;
using System.Collections.Generic;

namespace API.Model;

public partial class QuickAccounting
{
    public string? DataType { get; set; }

    public string? KeyWord { get; set; }

    public string? Desctiption { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public Guid Id { get; set; }

    public int? CodeUnit { get; set; }

    public int IdAsc { get; set; }

    public string? Notes { get; set; }
}
