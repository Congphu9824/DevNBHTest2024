using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogShippingMethod
{
    public string ShippingMethodsCode { get; set; } = null!;

    public string? ShippingMethodsName { get; set; }

    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public int? CodeUnit { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }
}
