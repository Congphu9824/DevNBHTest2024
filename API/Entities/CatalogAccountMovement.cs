﻿using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogAccountMovement
{
    public string? AccountSymbol { get; set; }

    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public int? Ordinal { get; set; }

    public string? Description { get; set; }

    public string? Notes { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }

    public int IdAsc { get; set; }

    public Guid Id { get; set; }
}
