using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class User
{
    public Guid Id { get; set; }

    public int? CodeUnit { get; set; }

    public string CodeUser { get; set; } = null!;

    public string? NameUser { get; set; }

    public string? PassUser { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public bool IsAdmin { get; set; }

    public bool IsMode { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public int IdAsc { get; set; }

    public string? Apiurl { get; set; }

    public string? Apiuser { get; set; }

    public string? Apipassword { get; set; }

    public string? Apitaxcode { get; set; }

    public string? DeliveryPointCode { get; set; }

    public string? HiloUserName { get; set; }

    public string? HiloUserNameQb { get; set; }

    public string? HiloUserNameNa { get; set; }

    public string? EmailUser { get; set; }
}
