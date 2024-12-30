using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class ListViewConfig
{
    public Guid Id { get; set; }

    public string? ComputerName { get; set; }

    public bool Allow { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }
}
