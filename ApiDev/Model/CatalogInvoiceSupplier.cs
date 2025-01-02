using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogInvoiceSupplier
{
    public int Id { get; set; }

    public string? SupplierCode { get; set; }

    public string? Notes { get; set; }
}
