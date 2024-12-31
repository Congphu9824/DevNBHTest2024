using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SmartLog
{
    public int Id { get; set; }

    public DateTime CreateDate { get; set; }

    public string? StoreName { get; set; }

    public int? ErrorNumber { get; set; }

    public int? ErrorSeverity { get; set; }

    public int? ErrorState { get; set; }

    public string? ErrorProcedure { get; set; }

    public int? ErrorLine { get; set; }

    public string? ErrorMessage { get; set; }

    public string? UserCode { get; set; }

    public string? Parameter { get; set; }

    public string? BeginDate { get; set; }

    public string? EndDate { get; set; }
}
