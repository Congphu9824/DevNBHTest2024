using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogBarcodeByProduct
{
    public Guid Id { get; set; }

    public int IdAsc { get; set; }

    public Guid? ProductId { get; set; }

    public string? CodeProduct { get; set; }

    public string? Barcode { get; set; }

    public string? Notes { get; set; }

    public string? CodeSupplier { get; set; }

    public string? NameSupplier { get; set; }

    public double? ImpPrice { get; set; }
}
