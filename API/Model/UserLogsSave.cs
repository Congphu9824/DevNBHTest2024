using System;
using System.Collections.Generic;

namespace API.Model;

public partial class UserLogsSave
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public DateTime DateAction { get; set; }

    public string? FunctionName { get; set; }

    public string? UserExc { get; set; }

    public int? CodeUnit { get; set; }

    public string? TypeOrderOrCode { get; set; }

    public string? FirstData { get; set; }

    public string? LastData { get; set; }

    public string? Notes { get; set; }

    public string? IdTracingModify { get; set; }

    public string? HeadFirstData { get; set; }

    public string? HeadLastData { get; set; }
}
