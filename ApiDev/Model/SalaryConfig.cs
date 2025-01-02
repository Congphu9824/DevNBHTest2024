using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class SalaryConfig
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? DataType { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? NumberBegin { get; set; }

    public decimal? NumberEnd { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public string? Content { get; set; }

    public double? Rate { get; set; }

    public decimal? Value { get; set; }
}
