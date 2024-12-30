﻿using System;
using System.Collections.Generic;

namespace API.Entities;

public partial class CatalogTypeOfMatarial
{
    public string TypeCode { get; set; } = null!;

    public string? TypeName { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }
}
