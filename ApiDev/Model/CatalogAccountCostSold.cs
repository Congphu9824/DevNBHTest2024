﻿using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogAccountCostSold
{
    public string? DebitSide { get; set; }

    public string? CreditSide { get; set; }

    public string? Description { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public Guid Identifier { get; set; }

    public int? CodeUnit { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }
}
