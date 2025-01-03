﻿using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class TradingSmartDataAllSum
{
    public Guid Id { get; set; }

    public bool SaveTemp { get; set; }

    public string? DataType { get; set; }

    public string? DataName { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? NumberOfVouchers { get; set; }

    public string? ObjectCode { get; set; }

    public string? ObjectName { get; set; }

    public string? ObjectAddress { get; set; }

    public string? WarehoseCode { get; set; }

    public string? WarehoseName { get; set; }

    public string WarehoseCodeReceive { get; set; } = null!;

    public string WarehoseNameReceive { get; set; } = null!;

    public string ReasonCode { get; set; } = null!;

    public string ReasonName { get; set; } = null!;

    public string? MethodOfPaymentsCode { get; set; }

    public string? MethodOfPaymentsName { get; set; }

    public int? CodeUnit { get; set; }

    public decimal? AmountOfMoney { get; set; }

    public decimal? AmountAfterDiscount { get; set; }

    public string? Description { get; set; }

    public string? StaffCode { get; set; }

    public string? StaffName { get; set; }
}
