﻿using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class SalesSmartDataSumWarehose
{
    public string? WarehoseCode { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public decimal? AmountAfterDiscount { get; set; }
}