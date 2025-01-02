using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class ReportCashFlow
{
    public int Id { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public int? CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public int? LevelSum { get; set; }

    public string? Code { get; set; }

    public string? Targets { get; set; }

    public string? CodeReport { get; set; }

    public string? Presentation { get; set; }

    public string? Formula { get; set; }

    public decimal? YearFirstNumber { get; set; }

    public decimal? YearEndNumber { get; set; }

    public string? AmountInWords { get; set; }

    public string? Headline { get; set; }

    public string? Template { get; set; }

    public string? Decision { get; set; }

    public string? Time { get; set; }
}
