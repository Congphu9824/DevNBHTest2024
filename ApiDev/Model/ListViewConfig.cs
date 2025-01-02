using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class ListViewConfig
{
    public Guid Id { get; set; }

    public string? ComputerName { get; set; }

    public bool Allow { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }
}
