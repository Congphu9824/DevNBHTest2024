using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogProgramPromotion
{
    public string FormOfPromotionCode { get; set; } = null!;

    public string? FormOfPromotionName { get; set; }

    public string? Notes { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public bool IsActive { get; set; }
}
