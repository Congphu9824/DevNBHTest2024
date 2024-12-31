using System;
using System.Collections.Generic;

namespace API.Model;

public partial class SmartFileAttach
{
    public Guid IdContents { get; set; }

    public int IdAsc { get; set; }

    public string? Xem { get; set; }

    public string? Description { get; set; }

    public string? PathFile { get; set; }

    public string? FileNames { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public string? NumberOfVouchers { get; set; }
}
