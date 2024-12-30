using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class FtpInformation
{
    public Guid Id { get; set; }

    public int CodeUnit { get; set; }

    public string CodeName { get; set; } = null!;

    public string? DomainName { get; set; }

    public string? Addressftp { get; set; }

    public string? UserNameftp { get; set; }

    public string? Passwordftp { get; set; }

    public string? Port { get; set; }

    public string? Notes { get; set; }

    public string? IpAddress { get; set; }
}
