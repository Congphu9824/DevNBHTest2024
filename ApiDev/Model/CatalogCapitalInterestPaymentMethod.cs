﻿using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogCapitalInterestPaymentMethod
{
    public string? Contents { get; set; }

    public int? NumberMonth { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }
}
