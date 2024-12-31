using System;
using System.Collections.Generic;

namespace API.Model;

public partial class CatalogGetInforEnterprise
{
    public int Id { get; set; }

    public bool IsActive { get; set; }

    public string? SupplierCode { get; set; }

    public string? LinkInfo { get; set; }

    public string? Notes { get; set; }

    public bool IsRealName { get; set; }
}
