using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class WsmartLogger
{
    public int Id { get; set; }

    public string? Message { get; set; }

    public string? MessageTemplate { get; set; }

    public string Level { get; set; } = null!;

    public DateTime TimeStamp { get; set; }

    public string? Exception { get; set; }

    public string? UserName { get; set; }

    public string? ClientIp { get; set; }

    public string? LocalIpAddress { get; set; }

    public string? MachineName { get; set; }

    public string? ClientAgent { get; set; }

    public string? Properties { get; set; }

    public string? LogEvent { get; set; }

    public string? WarehoseCode { get; set; }
}
