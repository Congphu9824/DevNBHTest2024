﻿using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class TradingUserLog
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public DateTime DateAction { get; set; }

    public string? FunctionName { get; set; }

    public string? UserExc { get; set; }

    public int? CodeUnit { get; set; }

    public string? TypeOrderOrCode { get; set; }

    public string? Notes { get; set; }

    public string? FirstData { get; set; }

    public string? LastData { get; set; }
}
