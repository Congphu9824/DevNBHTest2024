﻿using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogStatusShopingCart
{
    public string CodeStatus { get; set; } = null!;

    public string? NameStatus { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
