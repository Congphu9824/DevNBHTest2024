using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogScale
{
    public string? ScaleCode { get; set; }

    public string? ScaleName { get; set; }

    public int? BaudRate { get; set; }

    public int? Parity { get; set; }

    public int? StopBits { get; set; }

    public bool? DtrEnable { get; set; }

    public int? Handshake { get; set; }

    public int? DataBits { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
