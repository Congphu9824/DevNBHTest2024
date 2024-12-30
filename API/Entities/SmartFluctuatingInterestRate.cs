using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SmartFluctuatingInterestRate
{
    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public string? DataType { get; set; }

    public double? InterestRate { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }
}
