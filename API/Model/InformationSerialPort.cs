using System;
using System.Collections.Generic;

namespace API.Model;

public partial class InformationSerialPort
{
    public string? MachineId { get; set; }

    public string? PortName { get; set; }

    public int? BaudRate { get; set; }

    public int? DataBits { get; set; }

    public int? ReceivedBytesThreshold { get; set; }

    public bool? DtrEnable { get; set; }

    public string? UnitPcs { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public string? ScaleCode { get; set; }

    public Guid? ScaleId { get; set; }

    public string? ScaleName { get; set; }
}
