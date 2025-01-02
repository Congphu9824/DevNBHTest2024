using System;
using System.Collections.Generic;

namespace ApiDev.Model;

public partial class CatalogUnit
{
    public Guid Id { get; set; }

    public int IdUnitOk { get; set; }

    public int CodeUnit { get; set; }

    public string? NameUnit { get; set; }

    public string? Address { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public bool Vat { get; set; }

    public string? Symbol { get; set; }

    public string? PositionDir { get; set; }

    public string? DirectorName { get; set; }

    public string? Taxcode { get; set; }

    public bool ByBatchNo { get; set; }

    public bool RegisterSyncInv { get; set; }

    public bool LogInByWarehose { get; set; }
}
