using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogInfoSendMail
{
    public string? AddressMailSend { get; set; }

    public string? UserNameEmail { get; set; }

    public string? PasswordEmail { get; set; }

    public string? MailServer { get; set; }

    public string? PortMail { get; set; }

    public string? EmailSubject { get; set; }

    public string? EmailBody { get; set; }

    public int? DayDelete { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
